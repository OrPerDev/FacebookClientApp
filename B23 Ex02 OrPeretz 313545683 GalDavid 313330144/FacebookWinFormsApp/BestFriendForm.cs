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
                FriendScoreCreator friendScoreCreator = new FriendScoreCreator(new HighestFriendScoreBuilder(), this.r_FacebookAppManager.LoggedInUser);
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
    }
}
