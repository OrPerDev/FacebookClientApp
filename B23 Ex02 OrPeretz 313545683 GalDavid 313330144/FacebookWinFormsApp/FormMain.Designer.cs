using System.Drawing;

namespace BasicFacebookFeatures
{
    partial class FormMain
    {
        private static readonly Color sr_FacebookColor = Color.FromArgb(66, 103, 178);
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label eventNameLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label descriptionLabel1;
            System.Windows.Forms.Label nameLabel2;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label uRLLabel;
            System.Windows.Forms.Label linkLabel;
            System.Windows.Forms.Label messageLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label friendNameLabel;
            System.Windows.Forms.Label birthdayLabel1;
            System.Windows.Forms.Label userEmailLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label userCityNameLabel;
            System.Windows.Forms.Label linkToFacebookLabel;
            System.Windows.Forms.Label ticketsURILabel;
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label postLinkLabel;
            System.Windows.Forms.Label messageLabel1;
            System.Windows.Forms.Label albumCreatedTimeLabel;
            System.Windows.Forms.Label albumMessageLabel;
            System.Windows.Forms.Label descriptionLabel2;
            this.SwitchLogoutButton = new System.Windows.Forms.Button();
            this.GroupsTab = new System.Windows.Forms.TabPage();
            this.groupDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.GroupsListBox = new System.Windows.Forms.ListBox();
            this.LikedPagesTab = new System.Windows.Forms.TabPage();
            this.LikedPageURLLinkLabel = new System.Windows.Forms.LinkLabel();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.LikedPagesDescriptionTextbox = new System.Windows.Forms.TextBox();
            this.likedPageImagePicturebox = new System.Windows.Forms.PictureBox();
            this.LikedPagesNameTextbox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.LikedPagesListBox = new System.Windows.Forms.ListBox();
            this.AlbumsTab = new System.Windows.Forms.TabPage();
            this.albumCreatedTimeTextBox = new System.Windows.Forms.TextBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageAlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.albumMessageBox = new System.Windows.Forms.TextBox();
            this.GoToAlbumButton = new System.Windows.Forms.Button();
            this.AlbumsListBox = new System.Windows.Forms.ListBox();
            this.FeedTab = new System.Windows.Forms.TabPage();
            this.postImagePictureBox = new System.Windows.Forms.PictureBox();
            this.postCreatedTimeTextBox = new System.Windows.Forms.TextBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkLinkLabel = new System.Windows.Forms.LinkLabel();
            this.postMessageTextBox = new System.Windows.Forms.TextBox();
            this.FeedListBox = new System.Windows.Forms.ListBox();
            this.ControlTabs = new System.Windows.Forms.TabControl();
            this.TaggedPicturesTab = new System.Windows.Forms.TabPage();
            this.taggedPicturesPicturebox = new System.Windows.Forms.PictureBox();
            this.photoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taggedPhotoLinkLabel = new System.Windows.Forms.LinkLabel();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.TaggedPhotosListBox = new System.Windows.Forms.ListBox();
            this.EventsTab = new System.Windows.Forms.TabPage();
            this.ticketsURILinkLabel = new System.Windows.Forms.LinkLabel();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkToFacebookLinkLabel = new System.Windows.Forms.LinkLabel();
            this.eventDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.eventImagePicturebox = new System.Windows.Forms.PictureBox();
            this.eventLocationTextBox = new System.Windows.Forms.TextBox();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.EventsListBox = new System.Windows.Forms.ListBox();
            this.FriendsTab = new System.Windows.Forms.TabPage();
            this.friendImagePictureBox = new System.Windows.Forms.PictureBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.friendBirthdayTextBox = new System.Windows.Forms.TextBox();
            this.friendNameTextBox = new System.Windows.Forms.TextBox();
            this.BestFriendButton = new System.Windows.Forms.Button();
            this.FriendsListBox = new System.Windows.Forms.ListBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PostStatusButton = new System.Windows.Forms.Button();
            this.StatusRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ResumeBuilderButton = new System.Windows.Forms.Button();
            this.userBirthdayTextbox = new System.Windows.Forms.TextBox();
            this.userEmailTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userCityTextBox = new System.Windows.Forms.TextBox();
            this.userImagePictureBox = new System.Windows.Forms.PictureBox();
            descriptionLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            eventNameLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            descriptionLabel1 = new System.Windows.Forms.Label();
            nameLabel2 = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            uRLLabel = new System.Windows.Forms.Label();
            linkLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            friendNameLabel = new System.Windows.Forms.Label();
            birthdayLabel1 = new System.Windows.Forms.Label();
            userEmailLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            userCityNameLabel = new System.Windows.Forms.Label();
            linkToFacebookLabel = new System.Windows.Forms.Label();
            ticketsURILabel = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            postLinkLabel = new System.Windows.Forms.Label();
            messageLabel1 = new System.Windows.Forms.Label();
            albumCreatedTimeLabel = new System.Windows.Forms.Label();
            albumMessageLabel = new System.Windows.Forms.Label();
            descriptionLabel2 = new System.Windows.Forms.Label();
            this.GroupsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.LikedPagesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.likedPageImagePicturebox)).BeginInit();
            this.AlbumsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).BeginInit();
            this.FeedTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.ControlTabs.SuspendLayout();
            this.TaggedPicturesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taggedPicturesPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).BeginInit();
            this.EventsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventImagePicturebox)).BeginInit();
            this.FriendsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(246, 47);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(65, 15);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(246, 247);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(51, 15);
            locationLabel.TabIndex = 8;
            locationLabel.Text = "Location:";
            // 
            // eventNameLabel
            // 
            eventNameLabel.AutoSize = true;
            eventNameLabel.Location = new System.Drawing.Point(246, 6);
            eventNameLabel.Name = "eventNameLabel";
            eventNameLabel.Size = new System.Drawing.Size(38, 15);
            eventNameLabel.TabIndex = 10;
            eventNameLabel.Text = "Name:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(246, 277);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(53, 15);
            categoryLabel.TabIndex = 1;
            categoryLabel.Text = "Category:";
            // 
            // descriptionLabel1
            // 
            descriptionLabel1.AutoSize = true;
            descriptionLabel1.Location = new System.Drawing.Point(246, 54);
            descriptionLabel1.Name = "descriptionLabel1";
            descriptionLabel1.Size = new System.Drawing.Size(65, 15);
            descriptionLabel1.TabIndex = 3;
            descriptionLabel1.Text = "Description:";
            // 
            // nameLabel2
            // 
            nameLabel2.AutoSize = true;
            nameLabel2.Location = new System.Drawing.Point(246, 6);
            nameLabel2.Name = "nameLabel2";
            nameLabel2.Size = new System.Drawing.Size(38, 15);
            nameLabel2.TabIndex = 9;
            nameLabel2.Text = "Name:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(246, 324);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 15);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "Phone:";
            // 
            // uRLLabel
            // 
            uRLLabel.AutoSize = true;
            uRLLabel.Location = new System.Drawing.Point(246, 369);
            uRLLabel.Name = "uRLLabel";
            uRLLabel.Size = new System.Drawing.Size(29, 15);
            uRLLabel.TabIndex = 12;
            uRLLabel.Text = "URL:";
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Location = new System.Drawing.Point(249, 352);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new System.Drawing.Size(30, 15);
            linkLabel.TabIndex = 3;
            linkLabel.Text = "Link:";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(249, 7);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(53, 15);
            messageLabel.TabIndex = 5;
            messageLabel.Text = "Message:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(249, 58);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(51, 15);
            birthdayLabel.TabIndex = 60;
            birthdayLabel.Text = "Birthday:";
            // 
            // friendNameLabel
            // 
            friendNameLabel.AutoSize = true;
            friendNameLabel.Location = new System.Drawing.Point(246, 6);
            friendNameLabel.Name = "friendNameLabel";
            friendNameLabel.Size = new System.Drawing.Size(38, 15);
            friendNameLabel.TabIndex = 66;
            friendNameLabel.Text = "Name:";
            // 
            // birthdayLabel1
            // 
            birthdayLabel1.AutoSize = true;
            birthdayLabel1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthdayLabel1.Location = new System.Drawing.Point(582, 77);
            birthdayLabel1.Name = "birthdayLabel1";
            birthdayLabel1.Size = new System.Drawing.Size(72, 21);
            birthdayLabel1.TabIndex = 59;
            birthdayLabel1.Text = "Birthday:";
            // 
            // userEmailLabel
            // 
            userEmailLabel.AutoSize = true;
            userEmailLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userEmailLabel.Location = new System.Drawing.Point(582, 130);
            userEmailLabel.Name = "userEmailLabel";
            userEmailLabel.Size = new System.Drawing.Size(54, 21);
            userEmailLabel.TabIndex = 61;
            userEmailLabel.Text = "Email:";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userNameLabel.Location = new System.Drawing.Point(583, 23);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(55, 21);
            userNameLabel.TabIndex = 65;
            userNameLabel.Text = "Name:";
            // 
            // userCityNameLabel
            // 
            userCityNameLabel.AutoSize = true;
            userCityNameLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userCityNameLabel.Location = new System.Drawing.Point(582, 183);
            userCityNameLabel.Name = "userCityNameLabel";
            userCityNameLabel.Size = new System.Drawing.Size(35, 21);
            userCityNameLabel.TabIndex = 66;
            userCityNameLabel.Text = "City";
            // 
            // linkToFacebookLabel
            // 
            linkToFacebookLabel.AutoSize = true;
            linkToFacebookLabel.Location = new System.Drawing.Point(249, 306);
            linkToFacebookLabel.Name = "linkToFacebookLabel";
            linkToFacebookLabel.Size = new System.Drawing.Size(120, 15);
            linkToFacebookLabel.TabIndex = 11;
            linkToFacebookLabel.Text = "Link to facebook event:";
            // 
            // ticketsURILabel
            // 
            ticketsURILabel.AutoSize = true;
            ticketsURILabel.Location = new System.Drawing.Point(249, 344);
            ticketsURILabel.Name = "ticketsURILabel";
            ticketsURILabel.Size = new System.Drawing.Size(126, 15);
            ticketsURILabel.TabIndex = 12;
            ticketsURILabel.Text = "Link to purchase tickets:";
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(246, 184);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(74, 15);
            createdTimeLabel.TabIndex = 1;
            createdTimeLabel.Text = "Created Time:";
            // 
            // postLinkLabel
            // 
            postLinkLabel.AutoSize = true;
            postLinkLabel.Location = new System.Drawing.Point(246, 225);
            postLinkLabel.Name = "postLinkLabel";
            postLinkLabel.Size = new System.Drawing.Size(55, 15);
            postLinkLabel.TabIndex = 5;
            postLinkLabel.Text = "Post Link:";
            // 
            // messageLabel1
            // 
            messageLabel1.AutoSize = true;
            messageLabel1.Location = new System.Drawing.Point(246, 6);
            messageLabel1.Name = "messageLabel1";
            messageLabel1.Size = new System.Drawing.Size(53, 15);
            messageLabel1.TabIndex = 7;
            messageLabel1.Text = "Message:";
            // 
            // albumCreatedTimeLabel
            // 
            albumCreatedTimeLabel.AutoSize = true;
            albumCreatedTimeLabel.Location = new System.Drawing.Point(250, 166);
            albumCreatedTimeLabel.Name = "albumCreatedTimeLabel";
            albumCreatedTimeLabel.Size = new System.Drawing.Size(74, 15);
            albumCreatedTimeLabel.TabIndex = 56;
            albumCreatedTimeLabel.Text = "Created Time:";
            // 
            // albumMessageLabel
            // 
            albumMessageLabel.AutoSize = true;
            albumMessageLabel.Location = new System.Drawing.Point(246, 6);
            albumMessageLabel.Name = "albumMessageLabel";
            albumMessageLabel.Size = new System.Drawing.Size(53, 15);
            albumMessageLabel.TabIndex = 60;
            albumMessageLabel.Text = "Message:";
            // 
            // descriptionLabel2
            // 
            descriptionLabel2.AutoSize = true;
            descriptionLabel2.Location = new System.Drawing.Point(249, 7);
            descriptionLabel2.Name = "descriptionLabel2";
            descriptionLabel2.Size = new System.Drawing.Size(65, 15);
            descriptionLabel2.TabIndex = 1;
            descriptionLabel2.Text = "Description:";
            // 
            // SwitchLogoutButton
            // 
            this.SwitchLogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.SwitchLogoutButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwitchLogoutButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SwitchLogoutButton.Location = new System.Drawing.Point(587, 697);
            this.SwitchLogoutButton.Name = "SwitchLogoutButton";
            this.SwitchLogoutButton.Size = new System.Drawing.Size(280, 35);
            this.SwitchLogoutButton.TabIndex = 52;
            this.SwitchLogoutButton.Text = "Switch User / Logout";
            this.SwitchLogoutButton.UseVisualStyleBackColor = false;
            this.SwitchLogoutButton.Click += new System.EventHandler(this.SwitchLogoutButton_Click);
            // 
            // GroupsTab
            // 
            this.GroupsTab.AutoScroll = true;
            this.GroupsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.GroupsTab.Controls.Add(descriptionLabel2);
            this.GroupsTab.Controls.Add(this.groupDescriptionTextBox);
            this.GroupsTab.Controls.Add(this.imageNormalPictureBox);
            this.GroupsTab.Controls.Add(this.GroupsListBox);
            this.GroupsTab.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GroupsTab.Location = new System.Drawing.Point(4, 24);
            this.GroupsTab.Name = "GroupsTab";
            this.GroupsTab.Size = new System.Drawing.Size(565, 748);
            this.GroupsTab.TabIndex = 3;
            this.GroupsTab.Text = "Groups";
            // 
            // groupDescriptionTextBox
            // 
            this.groupDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Description", true));
            this.groupDescriptionTextBox.Enabled = false;
            this.groupDescriptionTextBox.Location = new System.Drawing.Point(246, 28);
            this.groupDescriptionTextBox.Multiline = true;
            this.groupDescriptionTextBox.Name = "groupDescriptionTextBox";
            this.groupDescriptionTextBox.ReadOnly = true;
            this.groupDescriptionTextBox.Size = new System.Drawing.Size(290, 182);
            this.groupDescriptionTextBox.TabIndex = 2;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.groupBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.ErrorImage = global::BasicFacebookFeatures.Properties.Resources.No_Image_Available;
            this.imageNormalPictureBox.Image = global::BasicFacebookFeatures.Properties.Resources.No_Image_Available;
            this.imageNormalPictureBox.InitialImage = global::BasicFacebookFeatures.Properties.Resources.No_Image_Available;
            this.imageNormalPictureBox.Location = new System.Drawing.Point(246, 429);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(290, 290);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 4;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // GroupsListBox
            // 
            this.GroupsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.GroupsListBox.DataSource = this.groupBindingSource;
            this.GroupsListBox.DisplayMember = "Name";
            this.GroupsListBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupsListBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GroupsListBox.FormattingEnabled = true;
            this.GroupsListBox.ItemHeight = 17;
            this.GroupsListBox.Location = new System.Drawing.Point(3, 18);
            this.GroupsListBox.Name = "GroupsListBox";
            this.GroupsListBox.Size = new System.Drawing.Size(240, 701);
            this.GroupsListBox.TabIndex = 1;
            // 
            // LikedPagesTab
            // 
            this.LikedPagesTab.AutoScroll = true;
            this.LikedPagesTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.LikedPagesTab.Controls.Add(uRLLabel);
            this.LikedPagesTab.Controls.Add(this.LikedPageURLLinkLabel);
            this.LikedPagesTab.Controls.Add(categoryLabel);
            this.LikedPagesTab.Controls.Add(this.categoryTextBox);
            this.LikedPagesTab.Controls.Add(descriptionLabel1);
            this.LikedPagesTab.Controls.Add(this.LikedPagesDescriptionTextbox);
            this.LikedPagesTab.Controls.Add(this.likedPageImagePicturebox);
            this.LikedPagesTab.Controls.Add(nameLabel2);
            this.LikedPagesTab.Controls.Add(this.LikedPagesNameTextbox);
            this.LikedPagesTab.Controls.Add(phoneLabel);
            this.LikedPagesTab.Controls.Add(this.phoneTextBox);
            this.LikedPagesTab.Controls.Add(this.LikedPagesListBox);
            this.LikedPagesTab.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LikedPagesTab.Location = new System.Drawing.Point(4, 24);
            this.LikedPagesTab.Name = "LikedPagesTab";
            this.LikedPagesTab.Padding = new System.Windows.Forms.Padding(3);
            this.LikedPagesTab.Size = new System.Drawing.Size(565, 748);
            this.LikedPagesTab.TabIndex = 2;
            this.LikedPagesTab.Text = "Liked Pages";
            // 
            // LikedPageURLLinkLabel
            // 
            this.LikedPageURLLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "URL", true));
            this.LikedPageURLLinkLabel.LinkColor = System.Drawing.SystemColors.ButtonFace;
            this.LikedPageURLLinkLabel.Location = new System.Drawing.Point(246, 384);
            this.LikedPageURLLinkLabel.Name = "LikedPageURLLinkLabel";
            this.LikedPageURLLinkLabel.Size = new System.Drawing.Size(293, 27);
            this.LikedPageURLLinkLabel.TabIndex = 13;
            this.LikedPageURLLinkLabel.TabStop = true;
            this.LikedPageURLLinkLabel.Text = "linkLabel1";
            this.LikedPageURLLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.general_LinkClicked);
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Category", true));
            this.categoryTextBox.Enabled = false;
            this.categoryTextBox.Location = new System.Drawing.Point(246, 295);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(290, 20);
            this.categoryTextBox.TabIndex = 2;
            // 
            // LikedPagesDescriptionTextbox
            // 
            this.LikedPagesDescriptionTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Description", true));
            this.LikedPagesDescriptionTextbox.Enabled = false;
            this.LikedPagesDescriptionTextbox.Location = new System.Drawing.Point(246, 72);
            this.LikedPagesDescriptionTextbox.Multiline = true;
            this.LikedPagesDescriptionTextbox.Name = "LikedPagesDescriptionTextbox";
            this.LikedPagesDescriptionTextbox.Size = new System.Drawing.Size(290, 196);
            this.LikedPagesDescriptionTextbox.TabIndex = 4;
            // 
            // likedPageImagePicturebox
            // 
            this.likedPageImagePicturebox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageNormal", true));
            this.likedPageImagePicturebox.ErrorImage = global::BasicFacebookFeatures.Properties.Resources.No_Image_Available;
            this.likedPageImagePicturebox.Image = global::BasicFacebookFeatures.Properties.Resources.No_Image_Available;
            this.likedPageImagePicturebox.InitialImage = global::BasicFacebookFeatures.Properties.Resources.No_Image_Available;
            this.likedPageImagePicturebox.Location = new System.Drawing.Point(246, 414);
            this.likedPageImagePicturebox.Name = "likedPageImagePicturebox";
            this.likedPageImagePicturebox.Size = new System.Drawing.Size(300, 305);
            this.likedPageImagePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.likedPageImagePicturebox.TabIndex = 6;
            this.likedPageImagePicturebox.TabStop = false;
            // 
            // LikedPagesNameTextbox
            // 
            this.LikedPagesNameTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Name", true));
            this.LikedPagesNameTextbox.Enabled = false;
            this.LikedPagesNameTextbox.Location = new System.Drawing.Point(246, 28);
            this.LikedPagesNameTextbox.Name = "LikedPagesNameTextbox";
            this.LikedPagesNameTextbox.ReadOnly = true;
            this.LikedPagesNameTextbox.Size = new System.Drawing.Size(290, 20);
            this.LikedPagesNameTextbox.TabIndex = 10;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Phone", true));
            this.phoneTextBox.Enabled = false;
            this.phoneTextBox.Location = new System.Drawing.Point(246, 342);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(290, 20);
            this.phoneTextBox.TabIndex = 12;
            // 
            // LikedPagesListBox
            // 
            this.LikedPagesListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.LikedPagesListBox.DataSource = this.pageBindingSource;
            this.LikedPagesListBox.DisplayMember = "Name";
            this.LikedPagesListBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LikedPagesListBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LikedPagesListBox.FormattingEnabled = true;
            this.LikedPagesListBox.ItemHeight = 17;
            this.LikedPagesListBox.Location = new System.Drawing.Point(3, 18);
            this.LikedPagesListBox.Name = "LikedPagesListBox";
            this.LikedPagesListBox.Size = new System.Drawing.Size(240, 701);
            this.LikedPagesListBox.TabIndex = 0;
            // 
            // AlbumsTab
            // 
            this.AlbumsTab.AutoScroll = true;
            this.AlbumsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.AlbumsTab.Controls.Add(albumCreatedTimeLabel);
            this.AlbumsTab.Controls.Add(this.albumCreatedTimeTextBox);
            this.AlbumsTab.Controls.Add(this.imageAlbumPictureBox);
            this.AlbumsTab.Controls.Add(albumMessageLabel);
            this.AlbumsTab.Controls.Add(this.albumMessageBox);
            this.AlbumsTab.Controls.Add(this.GoToAlbumButton);
            this.AlbumsTab.Controls.Add(this.AlbumsListBox);
            this.AlbumsTab.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AlbumsTab.Location = new System.Drawing.Point(4, 24);
            this.AlbumsTab.Name = "AlbumsTab";
            this.AlbumsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AlbumsTab.Size = new System.Drawing.Size(565, 748);
            this.AlbumsTab.TabIndex = 1;
            this.AlbumsTab.Text = "Albums";
            // 
            // albumCreatedTimeTextBox
            // 
            this.albumCreatedTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "CreatedTime", true));
            this.albumCreatedTimeTextBox.Enabled = false;
            this.albumCreatedTimeTextBox.Location = new System.Drawing.Point(249, 184);
            this.albumCreatedTimeTextBox.Name = "albumCreatedTimeTextBox";
            this.albumCreatedTimeTextBox.ReadOnly = true;
            this.albumCreatedTimeTextBox.Size = new System.Drawing.Size(290, 20);
            this.albumCreatedTimeTextBox.TabIndex = 57;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // imageAlbumPictureBox
            // 
            this.imageAlbumPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "ImageAlbum", true));
            this.imageAlbumPictureBox.ErrorImage = global::BasicFacebookFeatures.Properties.Resources.No_Image_Available;
            this.imageAlbumPictureBox.Image = global::BasicFacebookFeatures.Properties.Resources.No_Image_Available;
            this.imageAlbumPictureBox.InitialImage = global::BasicFacebookFeatures.Properties.Resources.No_Image_Available;
            this.imageAlbumPictureBox.Location = new System.Drawing.Point(249, 216);
            this.imageAlbumPictureBox.Name = "imageAlbumPictureBox";
            this.imageAlbumPictureBox.Size = new System.Drawing.Size(290, 290);
            this.imageAlbumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageAlbumPictureBox.TabIndex = 59;
            this.imageAlbumPictureBox.TabStop = false;
            // 
            // albumMessageBox
            // 
            this.albumMessageBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Message", true));
            this.albumMessageBox.Enabled = false;
            this.albumMessageBox.Location = new System.Drawing.Point(249, 26);
            this.albumMessageBox.Multiline = true;
            this.albumMessageBox.Name = "albumMessageBox";
            this.albumMessageBox.ReadOnly = true;
            this.albumMessageBox.Size = new System.Drawing.Size(290, 131);
            this.albumMessageBox.TabIndex = 61;
            // 
            // GoToAlbumButton
            // 
            this.GoToAlbumButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.GoToAlbumButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToAlbumButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GoToAlbumButton.Location = new System.Drawing.Point(253, 649);
            this.GoToAlbumButton.Name = "GoToAlbumButton";
            this.GoToAlbumButton.Size = new System.Drawing.Size(290, 70);
            this.GoToAlbumButton.TabIndex = 56;
            this.GoToAlbumButton.Text = "Display Album";
            this.GoToAlbumButton.UseVisualStyleBackColor = false;
            this.GoToAlbumButton.Click += new System.EventHandler(this.GoToAlbumButton_Click);
            // 
            // AlbumsListBox
            // 
            this.AlbumsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.AlbumsListBox.DataSource = this.albumBindingSource;
            this.AlbumsListBox.DisplayMember = "Name";
            this.AlbumsListBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumsListBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AlbumsListBox.FormattingEnabled = true;
            this.AlbumsListBox.ItemHeight = 17;
            this.AlbumsListBox.Location = new System.Drawing.Point(3, 18);
            this.AlbumsListBox.Name = "AlbumsListBox";
            this.AlbumsListBox.Size = new System.Drawing.Size(240, 701);
            this.AlbumsListBox.TabIndex = 0;
            // 
            // FeedTab
            // 
            this.FeedTab.AutoScroll = true;
            this.FeedTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.FeedTab.Controls.Add(this.postImagePictureBox);
            this.FeedTab.Controls.Add(createdTimeLabel);
            this.FeedTab.Controls.Add(this.postCreatedTimeTextBox);
            this.FeedTab.Controls.Add(postLinkLabel);
            this.FeedTab.Controls.Add(this.linkLinkLabel);
            this.FeedTab.Controls.Add(messageLabel1);
            this.FeedTab.Controls.Add(this.postMessageTextBox);
            this.FeedTab.Controls.Add(this.FeedListBox);
            this.FeedTab.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FeedTab.Location = new System.Drawing.Point(4, 24);
            this.FeedTab.Name = "FeedTab";
            this.FeedTab.Padding = new System.Windows.Forms.Padding(3);
            this.FeedTab.Size = new System.Drawing.Size(565, 748);
            this.FeedTab.TabIndex = 0;
            this.FeedTab.Text = "Feed";
            // 
            // postImagePictureBox
            // 
            this.postImagePictureBox.ErrorImage = global::BasicFacebookFeatures.Properties.Resources.No_Image_Available;
            this.postImagePictureBox.Image = global::BasicFacebookFeatures.Properties.Resources.No_Image_Available;
            this.postImagePictureBox.InitialImage = global::BasicFacebookFeatures.Properties.Resources.No_Image_Available;
            this.postImagePictureBox.Location = new System.Drawing.Point(249, 429);
            this.postImagePictureBox.Name = "postImagePictureBox";
            this.postImagePictureBox.Size = new System.Drawing.Size(290, 290);
            this.postImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.postImagePictureBox.TabIndex = 9;
            this.postImagePictureBox.TabStop = false;
            // 
            // postCreatedTimeTextBox
            // 
            this.postCreatedTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "CreatedTime", true));
            this.postCreatedTimeTextBox.Enabled = false;
            this.postCreatedTimeTextBox.Location = new System.Drawing.Point(249, 202);
            this.postCreatedTimeTextBox.Name = "postCreatedTimeTextBox";
            this.postCreatedTimeTextBox.ReadOnly = true;
            this.postCreatedTimeTextBox.Size = new System.Drawing.Size(296, 20);
            this.postCreatedTimeTextBox.TabIndex = 2;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // linkLinkLabel
            // 
            this.linkLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Link", true));
            this.linkLinkLabel.LinkColor = System.Drawing.SystemColors.ButtonFace;
            this.linkLinkLabel.Location = new System.Drawing.Point(246, 240);
            this.linkLinkLabel.Name = "linkLinkLabel";
            this.linkLinkLabel.Size = new System.Drawing.Size(296, 23);
            this.linkLinkLabel.TabIndex = 6;
            this.linkLinkLabel.TabStop = true;
            this.linkLinkLabel.Text = "linkLabel1";
            // 
            // postMessageTextBox
            // 
            this.postMessageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true));
            this.postMessageTextBox.Enabled = false;
            this.postMessageTextBox.Location = new System.Drawing.Point(249, 28);
            this.postMessageTextBox.Multiline = true;
            this.postMessageTextBox.Name = "postMessageTextBox";
            this.postMessageTextBox.ReadOnly = true;
            this.postMessageTextBox.Size = new System.Drawing.Size(296, 153);
            this.postMessageTextBox.TabIndex = 8;
            // 
            // FeedListBox
            // 
            this.FeedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.FeedListBox.DataSource = this.postBindingSource;
            this.FeedListBox.DisplayMember = "Message";
            this.FeedListBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedListBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FeedListBox.FormattingEnabled = true;
            this.FeedListBox.ItemHeight = 17;
            this.FeedListBox.Location = new System.Drawing.Point(3, 18);
            this.FeedListBox.Name = "FeedListBox";
            this.FeedListBox.Size = new System.Drawing.Size(240, 701);
            this.FeedListBox.TabIndex = 0;
            this.FeedListBox.SelectedIndexChanged += new System.EventHandler(this.FeedListBox_SelectedIndexChanged);
            // 
            // ControlTabs
            // 
            this.ControlTabs.Controls.Add(this.FeedTab);
            this.ControlTabs.Controls.Add(this.AlbumsTab);
            this.ControlTabs.Controls.Add(this.TaggedPicturesTab);
            this.ControlTabs.Controls.Add(this.LikedPagesTab);
            this.ControlTabs.Controls.Add(this.GroupsTab);
            this.ControlTabs.Controls.Add(this.EventsTab);
            this.ControlTabs.Controls.Add(this.FriendsTab);
            this.ControlTabs.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlTabs.Location = new System.Drawing.Point(1, -1);
            this.ControlTabs.Name = "ControlTabs";
            this.ControlTabs.SelectedIndex = 0;
            this.ControlTabs.Size = new System.Drawing.Size(573, 776);
            this.ControlTabs.TabIndex = 53;
            this.ControlTabs.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.ControlTabs_Selecting);
            // 
            // TaggedPicturesTab
            // 
            this.TaggedPicturesTab.AutoScroll = true;
            this.TaggedPicturesTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.TaggedPicturesTab.Controls.Add(this.taggedPicturesPicturebox);
            this.TaggedPicturesTab.Controls.Add(linkLabel);
            this.TaggedPicturesTab.Controls.Add(this.taggedPhotoLinkLabel);
            this.TaggedPicturesTab.Controls.Add(messageLabel);
            this.TaggedPicturesTab.Controls.Add(this.messageTextBox);
            this.TaggedPicturesTab.Controls.Add(this.TaggedPhotosListBox);
            this.TaggedPicturesTab.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaggedPicturesTab.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TaggedPicturesTab.Location = new System.Drawing.Point(4, 24);
            this.TaggedPicturesTab.Name = "TaggedPicturesTab";
            this.TaggedPicturesTab.Size = new System.Drawing.Size(565, 748);
            this.TaggedPicturesTab.TabIndex = 4;
            this.TaggedPicturesTab.Text = "Tagged Pictures";
            // 
            // taggedPicturesPicturebox
            // 
            this.taggedPicturesPicturebox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.photoBindingSource, "ImageNormal", true));
            this.taggedPicturesPicturebox.ErrorImage = global::BasicFacebookFeatures.Properties.Resources.No_Image_Available;
            this.taggedPicturesPicturebox.Image = global::BasicFacebookFeatures.Properties.Resources.No_Image_Available;
            this.taggedPicturesPicturebox.InitialImage = global::BasicFacebookFeatures.Properties.Resources.No_Image_Available;
            this.taggedPicturesPicturebox.Location = new System.Drawing.Point(252, 429);
            this.taggedPicturesPicturebox.Name = "taggedPicturesPicturebox";
            this.taggedPicturesPicturebox.Size = new System.Drawing.Size(290, 290);
            this.taggedPicturesPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.taggedPicturesPicturebox.TabIndex = 2;
            this.taggedPicturesPicturebox.TabStop = false;
            // 
            // photoBindingSource
            // 
            this.photoBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Photo);
            // 
            // taggedPhotoLinkLabel
            // 
            this.taggedPhotoLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoBindingSource, "Link", true));
            this.taggedPhotoLinkLabel.LinkColor = System.Drawing.SystemColors.ButtonFace;
            this.taggedPhotoLinkLabel.Location = new System.Drawing.Point(249, 369);
            this.taggedPhotoLinkLabel.Name = "taggedPhotoLinkLabel";
            this.taggedPhotoLinkLabel.Size = new System.Drawing.Size(289, 27);
            this.taggedPhotoLinkLabel.TabIndex = 4;
            this.taggedPhotoLinkLabel.TabStop = true;
            this.taggedPhotoLinkLabel.Text = "Link to facebook image";
            this.taggedPhotoLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.general_LinkClicked);
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoBindingSource, "Message", true));
            this.messageTextBox.Enabled = false;
            this.messageTextBox.Location = new System.Drawing.Point(252, 28);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.Size = new System.Drawing.Size(290, 320);
            this.messageTextBox.TabIndex = 6;
            this.messageTextBox.ModifiedChanged += new System.EventHandler(this.generalTextBox_TextChanged);
            this.messageTextBox.TextChanged += new System.EventHandler(this.generalTextBox_TextChanged);
            // 
            // TaggedPhotosListBox
            // 
            this.TaggedPhotosListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.TaggedPhotosListBox.DataSource = this.photoBindingSource;
            this.TaggedPhotosListBox.DisplayMember = "Name";
            this.TaggedPhotosListBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaggedPhotosListBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TaggedPhotosListBox.FormattingEnabled = true;
            this.TaggedPhotosListBox.ItemHeight = 17;
            this.TaggedPhotosListBox.Location = new System.Drawing.Point(3, 18);
            this.TaggedPhotosListBox.Name = "TaggedPhotosListBox";
            this.TaggedPhotosListBox.Size = new System.Drawing.Size(240, 701);
            this.TaggedPhotosListBox.TabIndex = 1;
            // 
            // EventsTab
            // 
            this.EventsTab.AutoScroll = true;
            this.EventsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.EventsTab.Controls.Add(ticketsURILabel);
            this.EventsTab.Controls.Add(this.ticketsURILinkLabel);
            this.EventsTab.Controls.Add(linkToFacebookLabel);
            this.EventsTab.Controls.Add(this.linkToFacebookLinkLabel);
            this.EventsTab.Controls.Add(descriptionLabel);
            this.EventsTab.Controls.Add(this.eventDescriptionTextBox);
            this.EventsTab.Controls.Add(this.eventImagePicturebox);
            this.EventsTab.Controls.Add(locationLabel);
            this.EventsTab.Controls.Add(this.eventLocationTextBox);
            this.EventsTab.Controls.Add(eventNameLabel);
            this.EventsTab.Controls.Add(this.eventNameTextBox);
            this.EventsTab.Controls.Add(this.EventsListBox);
            this.EventsTab.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EventsTab.Location = new System.Drawing.Point(4, 24);
            this.EventsTab.Name = "EventsTab";
            this.EventsTab.Size = new System.Drawing.Size(565, 748);
            this.EventsTab.TabIndex = 5;
            this.EventsTab.Text = "Events";
            // 
            // ticketsURILinkLabel
            // 
            this.ticketsURILinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "TicketsURI", true));
            this.ticketsURILinkLabel.LinkColor = System.Drawing.SystemColors.ButtonFace;
            this.ticketsURILinkLabel.Location = new System.Drawing.Point(250, 359);
            this.ticketsURILinkLabel.Name = "ticketsURILinkLabel";
            this.ticketsURILinkLabel.Size = new System.Drawing.Size(289, 23);
            this.ticketsURILinkLabel.TabIndex = 13;
            this.ticketsURILinkLabel.TabStop = true;
            this.ticketsURILinkLabel.Text = "linkLabel1";
            this.ticketsURILinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.general_LinkClicked);
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // linkToFacebookLinkLabel
            // 
            this.linkToFacebookLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "LinkToFacebook", true));
            this.linkToFacebookLinkLabel.LinkColor = System.Drawing.SystemColors.ButtonFace;
            this.linkToFacebookLinkLabel.Location = new System.Drawing.Point(249, 321);
            this.linkToFacebookLinkLabel.Name = "linkToFacebookLinkLabel";
            this.linkToFacebookLinkLabel.Size = new System.Drawing.Size(296, 23);
            this.linkToFacebookLinkLabel.TabIndex = 12;
            this.linkToFacebookLinkLabel.TabStop = true;
            this.linkToFacebookLinkLabel.Text = "linkLabel1";
            this.linkToFacebookLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.general_LinkClicked);
            // 
            // eventDescriptionTextBox
            // 
            this.eventDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.eventDescriptionTextBox.Enabled = false;
            this.eventDescriptionTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDescriptionTextBox.Location = new System.Drawing.Point(249, 65);
            this.eventDescriptionTextBox.Multiline = true;
            this.eventDescriptionTextBox.Name = "eventDescriptionTextBox";
            this.eventDescriptionTextBox.ReadOnly = true;
            this.eventDescriptionTextBox.Size = new System.Drawing.Size(296, 179);
            this.eventDescriptionTextBox.TabIndex = 3;
            // 
            // eventImagePicturebox
            // 
            this.eventImagePicturebox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageNormal", true));
            this.eventImagePicturebox.ErrorImage = global::BasicFacebookFeatures.Properties.Resources.No_Image_Available;
            this.eventImagePicturebox.Image = global::BasicFacebookFeatures.Properties.Resources.No_Image_Available;
            this.eventImagePicturebox.InitialImage = global::BasicFacebookFeatures.Properties.Resources.No_Image_Available;
            this.eventImagePicturebox.Location = new System.Drawing.Point(249, 434);
            this.eventImagePicturebox.Name = "eventImagePicturebox";
            this.eventImagePicturebox.Size = new System.Drawing.Size(290, 290);
            this.eventImagePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eventImagePicturebox.TabIndex = 5;
            this.eventImagePicturebox.TabStop = false;
            // 
            // eventLocationTextBox
            // 
            this.eventLocationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Location", true));
            this.eventLocationTextBox.Enabled = false;
            this.eventLocationTextBox.Location = new System.Drawing.Point(249, 265);
            this.eventLocationTextBox.Multiline = true;
            this.eventLocationTextBox.Name = "eventLocationTextBox";
            this.eventLocationTextBox.ReadOnly = true;
            this.eventLocationTextBox.Size = new System.Drawing.Size(296, 22);
            this.eventLocationTextBox.TabIndex = 9;
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Name", true));
            this.eventNameTextBox.Enabled = false;
            this.eventNameTextBox.Location = new System.Drawing.Point(249, 22);
            this.eventNameTextBox.Multiline = true;
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.ReadOnly = true;
            this.eventNameTextBox.Size = new System.Drawing.Size(296, 22);
            this.eventNameTextBox.TabIndex = 11;
            // 
            // EventsListBox
            // 
            this.EventsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.EventsListBox.DataSource = this.eventBindingSource;
            this.EventsListBox.DisplayMember = "Name";
            this.EventsListBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventsListBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EventsListBox.FormattingEnabled = true;
            this.EventsListBox.ItemHeight = 17;
            this.EventsListBox.Location = new System.Drawing.Point(3, 23);
            this.EventsListBox.Name = "EventsListBox";
            this.EventsListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EventsListBox.Size = new System.Drawing.Size(240, 701);
            this.EventsListBox.TabIndex = 2;
            // 
            // FriendsTab
            // 
            this.FriendsTab.AutoScroll = true;
            this.FriendsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.FriendsTab.Controls.Add(this.friendImagePictureBox);
            this.FriendsTab.Controls.Add(birthdayLabel);
            this.FriendsTab.Controls.Add(this.friendBirthdayTextBox);
            this.FriendsTab.Controls.Add(friendNameLabel);
            this.FriendsTab.Controls.Add(this.friendNameTextBox);
            this.FriendsTab.Controls.Add(this.BestFriendButton);
            this.FriendsTab.Controls.Add(this.FriendsListBox);
            this.FriendsTab.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FriendsTab.Location = new System.Drawing.Point(4, 24);
            this.FriendsTab.Name = "FriendsTab";
            this.FriendsTab.Size = new System.Drawing.Size(565, 748);
            this.FriendsTab.TabIndex = 6;
            this.FriendsTab.Text = "Friends";
            // 
            // friendImagePictureBox
            // 
            this.friendImagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageLarge", true));
            this.friendImagePictureBox.ErrorImage = global::BasicFacebookFeatures.Properties.Resources.Unknown_Profile_Picture;
            this.friendImagePictureBox.Image = global::BasicFacebookFeatures.Properties.Resources.Unknown_Profile_Picture;
            this.friendImagePictureBox.InitialImage = global::BasicFacebookFeatures.Properties.Resources.Unknown_Profile_Picture;
            this.friendImagePictureBox.Location = new System.Drawing.Point(249, 119);
            this.friendImagePictureBox.Name = "friendImagePictureBox";
            this.friendImagePictureBox.Size = new System.Drawing.Size(290, 290);
            this.friendImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.friendImagePictureBox.TabIndex = 68;
            this.friendImagePictureBox.TabStop = false;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // friendBirthdayTextBox
            // 
            this.friendBirthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.friendBirthdayTextBox.Enabled = false;
            this.friendBirthdayTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendBirthdayTextBox.Location = new System.Drawing.Point(249, 78);
            this.friendBirthdayTextBox.Name = "friendBirthdayTextBox";
            this.friendBirthdayTextBox.ReadOnly = true;
            this.friendBirthdayTextBox.Size = new System.Drawing.Size(290, 26);
            this.friendBirthdayTextBox.TabIndex = 61;
            // 
            // friendNameTextBox
            // 
            this.friendNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.friendNameTextBox.Enabled = false;
            this.friendNameTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendNameTextBox.Location = new System.Drawing.Point(249, 24);
            this.friendNameTextBox.Name = "friendNameTextBox";
            this.friendNameTextBox.ReadOnly = true;
            this.friendNameTextBox.Size = new System.Drawing.Size(290, 26);
            this.friendNameTextBox.TabIndex = 67;
            // 
            // BestFriendButton
            // 
            this.BestFriendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.BestFriendButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BestFriendButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BestFriendButton.Location = new System.Drawing.Point(249, 669);
            this.BestFriendButton.Name = "BestFriendButton";
            this.BestFriendButton.Size = new System.Drawing.Size(290, 55);
            this.BestFriendButton.TabIndex = 60;
            this.BestFriendButton.Text = "Find Who Is Your Best Facebook Friend";
            this.BestFriendButton.UseVisualStyleBackColor = false;
            this.BestFriendButton.Click += new System.EventHandler(this.BestFriendButton_Click);
            // 
            // FriendsListBox
            // 
            this.FriendsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.FriendsListBox.DataSource = this.userBindingSource;
            this.FriendsListBox.DisplayMember = "Name";
            this.FriendsListBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendsListBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FriendsListBox.FormattingEnabled = true;
            this.FriendsListBox.ItemHeight = 17;
            this.FriendsListBox.Location = new System.Drawing.Point(3, 23);
            this.FriendsListBox.Name = "FriendsListBox";
            this.FriendsListBox.Size = new System.Drawing.Size(240, 701);
            this.FriendsListBox.TabIndex = 3;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.City);
            // 
            // PostStatusButton
            // 
            this.PostStatusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.PostStatusButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostStatusButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PostStatusButton.Location = new System.Drawing.Point(586, 656);
            this.PostStatusButton.Name = "PostStatusButton";
            this.PostStatusButton.Size = new System.Drawing.Size(280, 35);
            this.PostStatusButton.TabIndex = 57;
            this.PostStatusButton.Text = "Post Status";
            this.PostStatusButton.UseVisualStyleBackColor = false;
            this.PostStatusButton.Click += new System.EventHandler(this.PostStatusButton_Click);
            // 
            // StatusRichTextBox
            // 
            this.StatusRichTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusRichTextBox.Location = new System.Drawing.Point(587, 525);
            this.StatusRichTextBox.Name = "StatusRichTextBox";
            this.StatusRichTextBox.Size = new System.Drawing.Size(280, 125);
            this.StatusRichTextBox.TabIndex = 58;
            this.StatusRichTextBox.Text = "";
            // 
            // ResumeBuilderButton
            // 
            this.ResumeBuilderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ResumeBuilderButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResumeBuilderButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ResumeBuilderButton.Location = new System.Drawing.Point(587, 740);
            this.ResumeBuilderButton.Name = "ResumeBuilderButton";
            this.ResumeBuilderButton.Size = new System.Drawing.Size(280, 35);
            this.ResumeBuilderButton.TabIndex = 59;
            this.ResumeBuilderButton.Text = "Facebook Resume Builder";
            this.ResumeBuilderButton.UseVisualStyleBackColor = false;
            this.ResumeBuilderButton.Click += new System.EventHandler(this.ResumeBuilderButton_Click);
            // 
            // userBirthdayTextbox
            // 
            this.userBirthdayTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.userBirthdayTextbox.Enabled = false;
            this.userBirthdayTextbox.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBirthdayTextbox.Location = new System.Drawing.Point(586, 101);
            this.userBirthdayTextbox.Name = "userBirthdayTextbox";
            this.userBirthdayTextbox.ReadOnly = true;
            this.userBirthdayTextbox.Size = new System.Drawing.Size(281, 26);
            this.userBirthdayTextbox.TabIndex = 60;
            // 
            // userEmailTextBox
            // 
            this.userEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.userEmailTextBox.Enabled = false;
            this.userEmailTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEmailTextBox.Location = new System.Drawing.Point(584, 154);
            this.userEmailTextBox.Name = "userEmailTextBox";
            this.userEmailTextBox.ReadOnly = true;
            this.userEmailTextBox.Size = new System.Drawing.Size(277, 26);
            this.userEmailTextBox.TabIndex = 62;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.userNameTextBox.Enabled = false;
            this.userNameTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(584, 45);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.ReadOnly = true;
            this.userNameTextBox.Size = new System.Drawing.Size(281, 26);
            this.userNameTextBox.TabIndex = 66;
            // 
            // userCityTextBox
            // 
            this.userCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "Name", true));
            this.userCityTextBox.Enabled = false;
            this.userCityTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCityTextBox.Location = new System.Drawing.Point(586, 207);
            this.userCityTextBox.Name = "userCityTextBox";
            this.userCityTextBox.ReadOnly = true;
            this.userCityTextBox.Size = new System.Drawing.Size(281, 26);
            this.userCityTextBox.TabIndex = 67;
            // 
            // userImagePictureBox
            // 
            this.userImagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageLarge", true));
            this.userImagePictureBox.ErrorImage = global::BasicFacebookFeatures.Properties.Resources.Unknown_Profile_Picture;
            this.userImagePictureBox.Image = global::BasicFacebookFeatures.Properties.Resources.Unknown_Profile_Picture;
            this.userImagePictureBox.InitialImage = global::BasicFacebookFeatures.Properties.Resources.Unknown_Profile_Picture;
            this.userImagePictureBox.Location = new System.Drawing.Point(586, 239);
            this.userImagePictureBox.Name = "userImagePictureBox";
            this.userImagePictureBox.Size = new System.Drawing.Size(280, 280);
            this.userImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImagePictureBox.TabIndex = 68;
            this.userImagePictureBox.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(876, 787);
            this.Controls.Add(this.userImagePictureBox);
            this.Controls.Add(userCityNameLabel);
            this.Controls.Add(this.userCityTextBox);
            this.Controls.Add(birthdayLabel1);
            this.Controls.Add(this.userBirthdayTextbox);
            this.Controls.Add(userEmailLabel);
            this.Controls.Add(this.userEmailTextBox);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.ResumeBuilderButton);
            this.Controls.Add(this.StatusRichTextBox);
            this.Controls.Add(this.PostStatusButton);
            this.Controls.Add(this.ControlTabs);
            this.Controls.Add(this.SwitchLogoutButton);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::BasicFacebookFeatures.Properties.Resources.facebook_icon;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook App DP";
            this.GroupsTab.ResumeLayout(false);
            this.GroupsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.LikedPagesTab.ResumeLayout(false);
            this.LikedPagesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.likedPageImagePicturebox)).EndInit();
            this.AlbumsTab.ResumeLayout(false);
            this.AlbumsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).EndInit();
            this.FeedTab.ResumeLayout(false);
            this.FeedTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.ControlTabs.ResumeLayout(false);
            this.TaggedPicturesTab.ResumeLayout(false);
            this.TaggedPicturesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taggedPicturesPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).EndInit();
            this.EventsTab.ResumeLayout(false);
            this.EventsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventImagePicturebox)).EndInit();
            this.FriendsTab.ResumeLayout(false);
            this.FriendsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.Button SwitchLogoutButton;
        private System.Windows.Forms.TabPage GroupsTab;
        private System.Windows.Forms.TabPage LikedPagesTab;
        private System.Windows.Forms.TabPage AlbumsTab;
        private System.Windows.Forms.TabPage FeedTab;
        private System.Windows.Forms.TabControl ControlTabs;
        private System.Windows.Forms.ListBox FeedListBox;
        private System.Windows.Forms.ListBox AlbumsListBox;
        private System.Windows.Forms.Button GoToAlbumButton;
        private System.Windows.Forms.ListBox LikedPagesListBox;
        private System.Windows.Forms.ListBox GroupsListBox;
        private System.Windows.Forms.TabPage TaggedPicturesTab;
        private System.Windows.Forms.ListBox TaggedPhotosListBox;
        private System.Windows.Forms.TabPage EventsTab;
        private System.Windows.Forms.ListBox EventsListBox;
        private System.Windows.Forms.Button PostStatusButton;
        private System.Windows.Forms.RichTextBox StatusRichTextBox;
        private System.Windows.Forms.TabPage FriendsTab;
        private System.Windows.Forms.ListBox FriendsListBox;
        private System.Windows.Forms.Button BestFriendButton;
        private System.Windows.Forms.Button ResumeBuilderButton;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.TextBox eventDescriptionTextBox;
        private System.Windows.Forms.PictureBox eventImagePicturebox;
        private System.Windows.Forms.TextBox eventLocationTextBox;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox LikedPagesDescriptionTextbox;
        private System.Windows.Forms.PictureBox likedPageImagePicturebox;
        private System.Windows.Forms.TextBox LikedPagesNameTextbox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.LinkLabel LikedPageURLLinkLabel;
        private System.Windows.Forms.PictureBox taggedPicturesPicturebox;
        private System.Windows.Forms.BindingSource photoBindingSource;
        private System.Windows.Forms.LinkLabel taggedPhotoLinkLabel;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.TextBox friendBirthdayTextBox;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TextBox friendNameTextBox;
        private System.Windows.Forms.TextBox userBirthdayTextbox;
        private System.Windows.Forms.TextBox userEmailTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox userCityTextBox;
        private System.Windows.Forms.PictureBox friendImagePictureBox;
        private System.Windows.Forms.PictureBox userImagePictureBox;
        private System.Windows.Forms.LinkLabel ticketsURILinkLabel;
        private System.Windows.Forms.LinkLabel linkToFacebookLinkLabel;
        private System.Windows.Forms.TextBox postCreatedTimeTextBox;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.LinkLabel linkLinkLabel;
        private System.Windows.Forms.TextBox postMessageTextBox;
        private System.Windows.Forms.PictureBox postImagePictureBox;
        private System.Windows.Forms.TextBox albumCreatedTimeTextBox;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.PictureBox imageAlbumPictureBox;
        private System.Windows.Forms.TextBox albumMessageBox;
        private System.Windows.Forms.TextBox groupDescriptionTextBox;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
    }
}

