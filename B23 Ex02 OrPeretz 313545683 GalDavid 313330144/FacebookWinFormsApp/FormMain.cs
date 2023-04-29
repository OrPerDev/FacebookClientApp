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
                this.updateUserInfo();
                this.ControlTabs.SelectedTab = this.FeedTab;
                this.populateTabList(
                    this.FeedListBox,
                    r_FacebookAppManager.FetchListOfDataToPopulateFromUser<Post>(i_CollectionPropertyName: "NewsFeed", i_FieldPropertyToPopulate: "Message"));
                this.Text = "Facebook DP App";
            }
            catch (Exception ex)
            {
                this.Text = "Facebook DP App";
                MessageBox.Show($"Could not fetch data due to - {ex.Message}", "Data Load Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateUserInfo()
        {
            this.NameLabel.Text = r_FacebookAppManager.LoggedInUser.Name;
            string userProfilePictureURL = r_FacebookAppManager.FetchUserProfilePictureURL(r_FacebookAppManager.LoggedInUser);
            if (!string.IsNullOrEmpty(userProfilePictureURL))
            {
                this.ProfilePicture.LoadAsync(r_FacebookAppManager.LoggedInUser.PictureLargeURL);
            }
            else
            {
                this.ProfilePicture.Image = Properties.Resources.Unknown_Profile_Picture;
            }

            this.UserInfoTextBox.Text = r_FacebookAppManager.FetchUserInfo(r_FacebookAppManager.LoggedInUser);
        }

        private void SwitchLogoutButton_Click(object sender, EventArgs e)
        {
            this.LogFormRoutine();
        }

        private void ControlTabs_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TabPage currentTab = (sender as TabControl).SelectedTab;
            this.enableControlsInTab(currentTab);
            try
            {
                this.Text = "Facebook DP App - Loading....";
                if (currentTab == this.FeedTab)
                {
                    this.populateTabList(
                        this.FeedListBox,
                        r_FacebookAppManager.FetchListOfDataToPopulateFromUser<Post>(i_CollectionPropertyName: "NewsFeed", i_FieldPropertyToPopulate: "Message"));
                }
                else if (currentTab == this.AlbumsTab)
                {
                    this.populateTabList(
                        this.AlbumsListBox,
                        r_FacebookAppManager.FetchListOfDataToPopulateFromUser<Album>(i_CollectionPropertyName: "Albums", i_FieldPropertyToPopulate: "Name"));
                }
                else if (currentTab == this.LikedPagesTab)
                {
                    this.populateTabList(
                        this.LikedPagesListBox,
                        r_FacebookAppManager.FetchListOfDataToPopulateFromUser<Page>(i_CollectionPropertyName: "LikedPages", i_FieldPropertyToPopulate: "Name"));
                }
                else if (currentTab == this.GroupsTab)
                {
                    this.populateTabList(
                        this.GroupsListBox,
                        r_FacebookAppManager.FetchListOfDataToPopulateFromUser<Group>(i_CollectionPropertyName: "Groups", i_FieldPropertyToPopulate: "Name"));
                }
                else if (currentTab == this.TaggedPicturesTab)
                {
                    this.populateTabList(
                        this.TaggedPhotosListBox,
                        r_FacebookAppManager.FetchListOfDataToPopulateFromUser<Photo>(i_CollectionPropertyName: "PhotosTaggedIn", i_FieldPropertyToPopulate: "Name"));
                }
                else if (currentTab == this.EventsTab)
                {
                    this.populateTabList(
                        this.EventsListBox,
                        r_FacebookAppManager.FetchListOfDataToPopulateFromUser<Event>(i_CollectionPropertyName: "Events", i_FieldPropertyToPopulate: "Name"));
                }
                else if (currentTab == this.FriendsTab)
                {
                    this.populateTabList(
                        this.FriendsListBox,
                        r_FacebookAppManager.FetchListOfDataToPopulateFromUser<User>(i_CollectionPropertyName: "Friends", i_FieldPropertyToPopulate: "Name"));
                }

                this.Text = "Facebook DP App";
            }
            catch (Exception ex)
            {
                string errorMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                this.Text = "Facebook DP App";
                MessageBox.Show($"Could not fetch data due to - {errorMessage}", "Data Load Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.disableControlsInTab(currentTab);
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

        private void populateTabList(ListBox i_ListBoxToPopulate, List<string> i_DataList)
        {
            if (i_DataList.Count == 0)
            {
                this.disableControlsInTab(this.ControlTabs.SelectedTab);
            }
            else
            {
                i_ListBoxToPopulate.DataSource = i_DataList;
            }
        }

        private void FeedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListBox currentListBox = sender as ListBox;
                string currentPostText = currentListBox.SelectedItem.ToString();
                Post currentPost = r_FacebookAppManager.GetDataMemberByText<Post>(currentPostText, "NewsFeed", "Message");
                this.SelectedPostTextBox.Text = r_FacebookAppManager.FetchDataDetailsByGeneric<Post>(currentPost, "Message", "CreatedTime");
                string imageUrl = r_FacebookAppManager.FetchPostImage(currentPost);
                if (!string.IsNullOrEmpty(imageUrl))
                {
                    this.PostPicture.LoadAsync(imageUrl);
                }
                else
                {
                    this.PostPicture.Image = Properties.Resources.No_Image_Available;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Facebook DP App - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GoToAlbumButton_Click(object sender, EventArgs e)
        {
            try
            {
                string currentAlbumName = this.AlbumsListBox.SelectedItem.ToString();
                Album currentAlbum = r_FacebookAppManager.GetDataMemberByText<Album>(currentAlbumName, "Albums", "Name");
                AlbumForm albumForm = new AlbumForm(currentAlbum);
                albumForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Facebook DP App - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LikedPagesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox currentListBox = sender as ListBox;
            try
            {
                string currentPageName = currentListBox.SelectedItem.ToString();
                Page currentPage = r_FacebookAppManager.GetDataMemberByText<Page>(currentPageName, "LikedPages", "Name");
                this.LikedPageDetailsTextBox.Clear();
                this.LikedPageDetailsTextBox.Text = r_FacebookAppManager.FetchDataDetailsByGeneric<Page>(currentPage, "Name", "Description");
                this.LikedPagePictureBox.Image = currentPage.ImageNormal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Facebook DP App - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GroupsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox currentListBox = sender as ListBox;
            try
            {
                string currentGroupName = currentListBox.SelectedItem.ToString();
                Group currentGroup = r_FacebookAppManager.GetDataMemberByText<Group>(currentGroupName, "Groups", "Name");
                this.GroupPictureBox.Image = currentGroup.ImageNormal;
                this.GroupInfoTextBox.Text = r_FacebookAppManager.FetchDataDetailsByGeneric<Group>(currentGroup, "Name", "Description");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Facebook DP App - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TaggedPhotosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox currentListBox = sender as ListBox;
            try
            {
                string currentPhotoName = currentListBox.SelectedItem.ToString();
                Photo currentPhoto = r_FacebookAppManager.GetDataMemberByText<Photo>(currentPhotoName, "PhotosTaggedIn", "Name");
                this.TaggedInPictureBox.Image = currentPhoto.ImageNormal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Facebook DP App - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GoToTaggedPicturePostButton_Click(object sender, EventArgs e)
        {
            try
            {
                string currentPhotoName = this.TaggedPhotosListBox.SelectedItem.ToString();
                Photo currentPhoto = r_FacebookAppManager.GetDataMemberByText<Photo>(currentPhotoName, "PhotosTaggedIn", "Name");
                System.Diagnostics.Process.Start(currentPhoto.Link);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Facebook DP App - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GoToPageButton_Click(object sender, EventArgs e)
        {
            try
            {
                string currentPageName = this.LikedPagesListBox.SelectedItem.ToString();
                Page currentPage = r_FacebookAppManager.GetDataMemberByText<Page>(currentPageName, "LikedPages", "Name");
                System.Diagnostics.Process.Start(currentPage.URL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Facebook DP App - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EventsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox currentListBox = sender as ListBox;
            try
            {
                string currentEventName = currentListBox.SelectedItem.ToString();
                Event currentEvent = r_FacebookAppManager.GetDataMemberByText<Event>(currentEventName, "Events", "Name");
                if (currentEvent == null)
                {
                    this.EventPictureBox.Image = Properties.Resources.No_Image_Available;
                    this.EventTextBox.Text = "No Data To Show";
                }
                else
                {
                    this.EventPictureBox.Image = currentEvent.ImageNormal != null ? currentEvent.ImageNormal : Properties.Resources.No_Image_Available;
                    this.EventTextBox.Text = r_FacebookAppManager.FetchDataDetailsByGeneric<Event>(currentEvent, "Name", "Location", "Description", "TicketsURI");
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

        private void FriendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox currentListBox = sender as ListBox;
            try
            {
                string currentFriendName = currentListBox.SelectedItem.ToString();
                this.FriendNameLabel.Text = currentFriendName;
                User currentUser = r_FacebookAppManager.GetDataMemberByText<User>(currentFriendName, "Friends", "Name");
                if (currentUser == null)
                {
                    this.FriendPictureBox.Image = Properties.Resources.No_Image_Available;
                    this.FriendInfoTextBox.Text = "No Data To Show";
                }
                else
                {
                    string friendProfilePictureURL = r_FacebookAppManager.FetchUserProfilePictureURL(currentUser);
                    if (string.IsNullOrEmpty(friendProfilePictureURL))
                    {
                        this.FriendPictureBox.Image = Properties.Resources.Unknown_Profile_Picture;
                    }
                    else
                    {
                        this.FriendPictureBox.LoadAsync(friendProfilePictureURL);
                    }

                    this.FriendInfoTextBox.Text = r_FacebookAppManager.FetchUserInfo(currentUser);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Facebook DP App - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void AlbumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox currentListBox = sender as ListBox;
            try
            {
                string currentAlbumName = currentListBox.SelectedItem.ToString();
                Album currentAlbum = r_FacebookAppManager.GetDataMemberByText<Album>(currentAlbumName, "Albums", "Name");
                if (currentAlbum == null)
                {
                    this.AlbumCoverPictureBox.Image = Properties.Resources.No_Image_Available;
                }
                else
                {
                    if (currentAlbum.Photos.Count == 0)
                    {
                        this.AlbumCoverPictureBox.Image = Properties.Resources.No_Image_Available;
                        this.GoToAlbumButton.Enabled = false;
                    }
                    else
                    {
                        this.AlbumCoverPictureBox.Image = currentAlbum.CoverPhoto != null ? currentAlbum.CoverPhoto.ImageNormal : Properties.Resources.No_Image_Available;
                        this.GoToAlbumButton.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                this.AlbumCoverPictureBox.Image = Properties.Resources.No_Image_Available;
                MessageBox.Show(ex.Message, "Facebook DP App - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
