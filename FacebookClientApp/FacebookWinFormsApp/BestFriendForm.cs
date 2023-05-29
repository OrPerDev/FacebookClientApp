using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookAppLogic;

namespace FacebookAppClient
{
    public partial class BestFriendForm : Form
    {
        private readonly AppManager r_FacebookAppManager = AppManager.Instance;
        private KeyValuePair<IFriendScore, User>? m_BestFriendAndScore = null;

        public BestFriendForm()
        {
            InitializeComponent();
        }

        private void FindBestFriendButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Facebook Best Friend - Calculating Best Friend Results";
                FriendScoreCreator friendScoreCreator = new FriendScoreCreator(new HighestFriendScoreBuilder(new FriendHighestScoreCalculator()), this.r_FacebookAppManager.LoggedInUser, (user) => !this.FilteredOutFriendsListBox.Items.Contains(user.Name));
                this.m_BestFriendAndScore = friendScoreCreator.ComposeFriendScoreResult();
                this.populateBestFriendData();
                this.Text = "Facebook DP App";
            }
            catch (Exception ex)
            {
                this.Text = "Facebook Best Friend";
                MessageBox.Show(ex.Message, "Facebook DP App - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void populateBestFriendData()
        {
            if (m_BestFriendAndScore.Value.Value != null)
            {
                string bestFriendInfo = r_FacebookAppManager.FetchUserInfo(m_BestFriendAndScore.Value.Value);
                bestFriendInfo += $@"• Friend Score - {this.m_BestFriendAndScore.Value.Key.Score}";
                this.FriendInfoTextBox.Text = bestFriendInfo;
                this.FriendNameLabel.Text = this.m_BestFriendAndScore.Value.Value.Name;
                string userProfilePictureURL = r_FacebookAppManager.FetchUserProfilePictureURL(this.m_BestFriendAndScore.Value.Value);
                if (!string.IsNullOrEmpty(userProfilePictureURL))
                {
                    this.FriendPictureBox.LoadAsync(this.m_BestFriendAndScore.Value.Value.PictureLargeURL);
                }
                else
                {
                    this.FriendPictureBox.Image = Properties.Resources.Unknown_Profile_Picture;
                }

                this.GoToFriendProfileButton.Enabled = true;
            }
            else
            {
                this.FriendInfoTextBox.Text = "No Information to display";
                this.FriendPictureBox.Image = Properties.Resources.Unknown_Profile_Picture;
                this.FriendNameLabel.Text = "Nothing To Show here";
                this.GoToFriendProfileButton.Enabled = false;
            }
        }

        private void GoToFriendProfileButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(this.m_BestFriendAndScore.Value.Value.Link);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Facebook DP App - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterFriendButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.NameFilterTextBox.Text))
            {
                MessageBox.Show("You must enter a name to filter!", "Facebook DP App", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.FilteredOutFriendsListBox.Items.Add(this.NameFilterTextBox.Text);
            }  
        }

        private void RemoveFilterFriendButton_Click(object sender, EventArgs e)
        {
            this.FilteredOutFriendsListBox.Items.Remove(this.FilteredOutFriendsListBox.SelectedItem);
        }

        private void FilteredOutFriendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox currentListBox = sender as ListBox;
            if (currentListBox.SelectedItem == null)
            {
                this.RemoveFilterFriendButton.Enabled = false;
            }
            else
            {
                this.RemoveFilterFriendButton.Enabled = true;
            }
        }
    }
}
