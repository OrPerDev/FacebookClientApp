using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookAppLogic;

namespace FacebookAppClient
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
                this.initLoggedUserDataSources();
                this.initDataSourcesAsync();
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
            this.removeBindingsFromLoggedUserComponents();
        }

        private async void initDataSourcesAsync()
        {
            try
            {
                this.postBindingSource.DataSource = await Task.Run(() => this.r_FacebookAppManager.LoggedInUser.NewsFeed);
                this.albumBindingSource.DataSource = await Task.Run(() => this.r_FacebookAppManager.LoggedInUser.Albums);
                this.pageBindingSource.DataSource = await Task.Run(() => this.r_FacebookAppManager.LoggedInUser.LikedPages);
                this.groupBindingSource.DataSource = await Task.Run(() => this.r_FacebookAppManager.LoggedInUser.Groups);
                this.eventBindingSource.DataSource = await Task.Run(() => this.r_FacebookAppManager.LoggedInUser.Events);
                this.userBindingSource.DataSource = await Task.Run(() => this.r_FacebookAppManager.LoggedInUser.Friends);
                this.photoBindingSource.DataSource = await Task.Run(() => this.r_FacebookAppManager.LoggedInUser.PhotosTaggedIn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Facebook DP App - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeBindingsFromLoggedUserComponents()
        {
            this.userNameTextBox.DataBindings.Clear();
            this.userBirthdayTextbox.DataBindings.Clear();
            this.userCityTextBox.DataBindings.Clear();
            this.userImagePictureBox.DataBindings.Clear();
            this.userEmailTextBox.DataBindings.Clear();
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
