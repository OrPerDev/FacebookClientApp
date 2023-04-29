using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookAppLogic;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private readonly AppManager r_FacebookAppManager = AppManager.Instance;

        public FormMain()
        {
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.LogFormRoutine();
        }

        private void LogFormRoutine()
        {
            FormAccountLog accountLogForm = new FormAccountLog();
            bool isUserQuit = false;
            accountLogForm.ShowDialog();
            while (!this.r_FacebookAppManager.IsUserLogged())
            {
                DialogResult userChoice = MessageBox.Show("You are not alllowed to move forward to user's dashboard without a user logged in, Do you wish to close the app?", "Facebook DP App - Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (userChoice == DialogResult.Yes)
                {
                    isUserQuit = true;
                    break;
                }

                accountLogForm.ShowDialog();
            }

            if (!isUserQuit)
            {
                this.initForm();
            }
            else
            {
                this.Close();
            }
        }

        private void initForm()
        {
            try
            {
                this.Text = "Facebook DP App - Loading....";
                this.initLoggedUserDataSources();
                this.removeBindingsFromLoggedUserComponents();
                this.initDataSources();
                this.Text = "Facebook DP App";
            }
            catch (Exception ex)
            {
                this.Text = "Facebook DP App";
                MessageBox.Show($"Could not fetch data due to - {ex.Message}", "Data Load Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void initLoggedUserDataSources()
        {
            this.userBindingSource.DataSource = this.r_FacebookAppManager.LoggedInUser;
            this.cityBindingSource.DataSource = this.r_FacebookAppManager.LoggedInUser.Location;
        }

        private void initDataSources()
        {
            this.postBindingSource.DataSource = this.r_FacebookAppManager.LoggedInUser.NewsFeed;
            this.albumBindingSource.DataSource = this.r_FacebookAppManager.LoggedInUser.Albums;
            this.pageBindingSource.DataSource = this.r_FacebookAppManager.LoggedInUser.LikedPages;
            this.groupBindingSource.DataSource = this.r_FacebookAppManager.LoggedInUser.Groups;
            this.userBindingSource.DataSource = this.r_FacebookAppManager.LoggedInUser.Friends;
            this.eventBindingSource.DataSource = this.r_FacebookAppManager.LoggedInUser.Events;
            this.photoBindingSource.DataSource = this.r_FacebookAppManager.LoggedInUser.PhotosTaggedIn;
        }

        private void removeBindingsFromLoggedUserComponents()
        {
            this.userNameTextBox.DataBindings.Clear();
            this.userBirthdayTextbox.DataBindings.Clear();
            this.userCityTextBox.DataBindings.Clear();
            this.userImagePictureBox.DataBindings.Clear();
            this.userEmailTextBox.DataBindings.Clear();  
        }

        private void SwitchLogoutButton_Click(object sender, EventArgs e)
        {
            this.LogFormRoutine();
        }

        private void ControlTabs_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TabPage currentTab = (sender as TabControl).SelectedTab;
            bool isListBoxEmpty = false;
            foreach (ListBox listBox in currentTab.Controls.OfType<ListBox>())
            {
                if (listBox.Items.Count == 0)
                {
                    this.disableControlsInTab(currentTab);
                    isListBoxEmpty = true;
                    break;
                }
            }
            if (!isListBoxEmpty)
            {
                this.enableControlsInTab(currentTab);
            }
        }

        private void disableControlsInTab(TabPage i_CurrentTab)
        {
            foreach (Button button in i_CurrentTab.Controls.OfType<Button>())
            {
                button.Enabled = false;
            }

            foreach (ListBox listBox in i_CurrentTab.Controls.OfType<ListBox>())
            {
                listBox.DataSource = new List<string> { "No Data To Be Presented" };
            }

            foreach (TextBox textBox in i_CurrentTab.Controls.OfType<TextBox>())
            {
                textBox.Text = "No information to be displayed";
            }

            foreach (PictureBox pictureBox in i_CurrentTab.Controls.OfType<PictureBox>())
            {
                pictureBox.Image = Properties.Resources.No_Image_Available;
            }

            foreach (ListBox listBox in i_CurrentTab.Controls.OfType<ListBox>())
            {
                listBox.Enabled = false;
            }
        }

        private void enableControlsInTab(TabPage i_CurrentTab)
        {
            foreach (Button button in i_CurrentTab.Controls.OfType<Button>())
            {
                button.Enabled = true;
            }

            foreach (ListBox listBox in i_CurrentTab.Controls.OfType<ListBox>())
            {
                listBox.Enabled = true;
            }
        }


        private void GoToAlbumButton_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox albumListBox = this.AlbumsListBox;
                if (albumListBox != null && albumListBox.SelectedItem != null)
                {
                    Album currentAlbum = albumListBox.SelectedItem as Album;
                    AlbumForm albumForm = new AlbumForm(currentAlbum);
                    albumForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Album is not accessible or empty", "Facebook DP App - Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Facebook DP App - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PostStatusButton_Click(object sender, EventArgs e)
        {
            string postText = this.StatusRichTextBox.Text;
            if (string.IsNullOrEmpty(postText))
            {
                MessageBox.Show(
                    "No status added, Please write down a status first and only then post the status",
                    "Facebook DP App - Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    r_FacebookAppManager.LoggedInUser.PostStatus(postText);
                }
                catch (Facebook.FacebookApiException)
                {
                    MessageBox.Show(
                        @"Post Status Api is deprecated...,
Even when having all the right permissions you cannot post...,
But you did well!", "Facebook DP App - Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void BestFriendButton_Click(object sender, EventArgs e)
        {
            try
            {
                BestFriendForm bestFriendForm = new BestFriendForm();
                bestFriendForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Facebook DP App - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.r_FacebookAppManager.AppUsersSettings.SaveUsersToDB();
            base.OnClosing(e);
        }

        private void ResumeBuilderButton_Click(object sender, EventArgs e)
        {
            ResumeBuilderForm resumeForm = new ResumeBuilderForm(this.r_FacebookAppManager.LoggedInUser);
            resumeForm.ShowDialog();
        }

        private void general_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                LinkLabel currentLinkLabel = sender as LinkLabel;
                System.Diagnostics.Process.Start(currentLinkLabel.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Facebook DP App - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generalTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox currentTextBox = sender as TextBox;
                if (string.IsNullOrEmpty(currentTextBox.Text))
                {
                    currentTextBox.Text = "No information to show...";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Facebook DP App - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FeedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListBox feedListBox = sender as ListBox;
                if (feedListBox != null && feedListBox.SelectedItem != null)
                {
                    Post currentPost = feedListBox.SelectedItem as Post;
                    if (currentPost.PictureURL != null)
                    {
                        this.postImagePictureBox.LoadAsync(currentPost.PictureURL);
                    }
                    else
                    {
                        this.postImagePictureBox.Image = Properties.Resources.No_Image_Available;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Facebook DP App - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
