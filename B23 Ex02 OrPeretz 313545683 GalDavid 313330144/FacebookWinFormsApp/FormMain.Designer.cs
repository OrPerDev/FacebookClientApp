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
            this.SwitchLogoutButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GroupsTab = new System.Windows.Forms.TabPage();
            this.GroupInfoTextBox = new System.Windows.Forms.TextBox();
            this.GroupPictureBox = new System.Windows.Forms.PictureBox();
            this.GroupsListBox = new System.Windows.Forms.ListBox();
            this.LikedPagesTab = new System.Windows.Forms.TabPage();
            this.GoToPageButton = new System.Windows.Forms.Button();
            this.LikedPageDetailsTextBox = new System.Windows.Forms.TextBox();
            this.LikedPagePictureBox = new System.Windows.Forms.PictureBox();
            this.LikedPagesListBox = new System.Windows.Forms.ListBox();
            this.AlbumsTab = new System.Windows.Forms.TabPage();
            this.GoToAlbumButton = new System.Windows.Forms.Button();
            this.AlbumsListBox = new System.Windows.Forms.ListBox();
            this.FeedTab = new System.Windows.Forms.TabPage();
            this.PostPicture = new System.Windows.Forms.PictureBox();
            this.SelectedPostTextBox = new System.Windows.Forms.TextBox();
            this.FeedListBox = new System.Windows.Forms.ListBox();
            this.ControlTabs = new System.Windows.Forms.TabControl();
            this.TaggedPicturesTab = new System.Windows.Forms.TabPage();
            this.GoToTaggedPicturePostButton = new System.Windows.Forms.Button();
            this.TaggedInPictureBox = new System.Windows.Forms.PictureBox();
            this.TaggedPhotosListBox = new System.Windows.Forms.ListBox();
            this.EventsTab = new System.Windows.Forms.TabPage();
            this.EventTextBox = new System.Windows.Forms.TextBox();
            this.EventPictureBox = new System.Windows.Forms.PictureBox();
            this.EventsListBox = new System.Windows.Forms.ListBox();
            this.FriendsTab = new System.Windows.Forms.TabPage();
            this.BestFriendButton = new System.Windows.Forms.Button();
            this.FriendInfoTextBox = new System.Windows.Forms.TextBox();
            this.FriendPictureBox = new System.Windows.Forms.PictureBox();
            this.FriendNameLabel = new System.Windows.Forms.Label();
            this.FriendsListBox = new System.Windows.Forms.ListBox();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.UserInfoTextBox = new System.Windows.Forms.TextBox();
            this.PostStatusButton = new System.Windows.Forms.Button();
            this.StatusRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ResumeBuilderButton = new System.Windows.Forms.Button();
            this.AlbumCoverPictureBox = new System.Windows.Forms.PictureBox();
            this.GroupsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupPictureBox)).BeginInit();
            this.LikedPagesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LikedPagePictureBox)).BeginInit();
            this.AlbumsTab.SuspendLayout();
            this.FeedTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PostPicture)).BeginInit();
            this.ControlTabs.SuspendLayout();
            this.TaggedPicturesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaggedInPictureBox)).BeginInit();
            this.EventsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventPictureBox)).BeginInit();
            this.FriendsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FriendPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumCoverPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SwitchLogoutButton
            // 
            this.SwitchLogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.SwitchLogoutButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwitchLogoutButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SwitchLogoutButton.Location = new System.Drawing.Point(567, 515);
            this.SwitchLogoutButton.Name = "SwitchLogoutButton";
            this.SwitchLogoutButton.Size = new System.Drawing.Size(250, 30);
            this.SwitchLogoutButton.TabIndex = 52;
            this.SwitchLogoutButton.Text = "Switch User / Logout";
            this.SwitchLogoutButton.UseVisualStyleBackColor = false;
            this.SwitchLogoutButton.Click += new System.EventHandler(this.SwitchLogoutButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(563, -1);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(59, 24);
            this.NameLabel.TabIndex = 54;
            this.NameLabel.Text = "Name";
            // 
            // GroupsTab
            // 
            this.GroupsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.GroupsTab.Controls.Add(this.GroupInfoTextBox);
            this.GroupsTab.Controls.Add(this.GroupPictureBox);
            this.GroupsTab.Controls.Add(this.GroupsListBox);
            this.GroupsTab.Location = new System.Drawing.Point(4, 24);
            this.GroupsTab.Name = "GroupsTab";
            this.GroupsTab.Size = new System.Drawing.Size(548, 550);
            this.GroupsTab.TabIndex = 3;
            this.GroupsTab.Text = "Groups";
            // 
            // GroupInfoTextBox
            // 
            this.GroupInfoTextBox.AcceptsReturn = true;
            this.GroupInfoTextBox.AcceptsTab = true;
            this.GroupInfoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.GroupInfoTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupInfoTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GroupInfoTextBox.Location = new System.Drawing.Point(249, 3);
            this.GroupInfoTextBox.MaxLength = 5000;
            this.GroupInfoTextBox.Multiline = true;
            this.GroupInfoTextBox.Name = "GroupInfoTextBox";
            this.GroupInfoTextBox.ReadOnly = true;
            this.GroupInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GroupInfoTextBox.Size = new System.Drawing.Size(292, 235);
            this.GroupInfoTextBox.TabIndex = 3;
            this.GroupInfoTextBox.Text = "Groups Details";
            // 
            // GroupPictureBox
            // 
            this.GroupPictureBox.Image = global::BasicFacebookFeatures.Properties.Resources.No_Image_Available;
            this.GroupPictureBox.Location = new System.Drawing.Point(249, 244);
            this.GroupPictureBox.Name = "GroupPictureBox";
            this.GroupPictureBox.Size = new System.Drawing.Size(292, 290);
            this.GroupPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GroupPictureBox.TabIndex = 2;
            this.GroupPictureBox.TabStop = false;
            // 
            // GroupsListBox
            // 
            this.GroupsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.GroupsListBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupsListBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GroupsListBox.FormattingEnabled = true;
            this.GroupsListBox.ItemHeight = 17;
            this.GroupsListBox.Location = new System.Drawing.Point(3, 3);
            this.GroupsListBox.Name = "GroupsListBox";
            this.GroupsListBox.Size = new System.Drawing.Size(240, 531);
            this.GroupsListBox.TabIndex = 1;
            this.GroupsListBox.SelectedIndexChanged += new System.EventHandler(this.GroupsListBox_SelectedIndexChanged);
            // 
            // LikedPagesTab
            // 
            this.LikedPagesTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.LikedPagesTab.Controls.Add(this.GoToPageButton);
            this.LikedPagesTab.Controls.Add(this.LikedPageDetailsTextBox);
            this.LikedPagesTab.Controls.Add(this.LikedPagePictureBox);
            this.LikedPagesTab.Controls.Add(this.LikedPagesListBox);
            this.LikedPagesTab.Location = new System.Drawing.Point(4, 24);
            this.LikedPagesTab.Name = "LikedPagesTab";
            this.LikedPagesTab.Padding = new System.Windows.Forms.Padding(3);
            this.LikedPagesTab.Size = new System.Drawing.Size(548, 550);
            this.LikedPagesTab.TabIndex = 2;
            this.LikedPagesTab.Text = "Liked Pages";
            // 
            // GoToPageButton
            // 
            this.GoToPageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.GoToPageButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToPageButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GoToPageButton.Location = new System.Drawing.Point(252, 492);
            this.GoToPageButton.Name = "GoToPageButton";
            this.GoToPageButton.Size = new System.Drawing.Size(290, 45);
            this.GoToPageButton.TabIndex = 54;
            this.GoToPageButton.Text = "Go To Page";
            this.GoToPageButton.UseVisualStyleBackColor = false;
            this.GoToPageButton.Click += new System.EventHandler(this.GoToPageButton_Click);
            // 
            // LikedPageDetailsTextBox
            // 
            this.LikedPageDetailsTextBox.AcceptsReturn = true;
            this.LikedPageDetailsTextBox.AcceptsTab = true;
            this.LikedPageDetailsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.LikedPageDetailsTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LikedPageDetailsTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LikedPageDetailsTextBox.Location = new System.Drawing.Point(253, 6);
            this.LikedPageDetailsTextBox.MaxLength = 5000;
            this.LikedPageDetailsTextBox.Multiline = true;
            this.LikedPageDetailsTextBox.Name = "LikedPageDetailsTextBox";
            this.LikedPageDetailsTextBox.ReadOnly = true;
            this.LikedPageDetailsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LikedPageDetailsTextBox.Size = new System.Drawing.Size(289, 225);
            this.LikedPageDetailsTextBox.TabIndex = 4;
            this.LikedPageDetailsTextBox.Text = "Page Details";
            // 
            // LikedPagePictureBox
            // 
            this.LikedPagePictureBox.Image = global::BasicFacebookFeatures.Properties.Resources.No_Image_Available;
            this.LikedPagePictureBox.Location = new System.Drawing.Point(253, 237);
            this.LikedPagePictureBox.Name = "LikedPagePictureBox";
            this.LikedPagePictureBox.Size = new System.Drawing.Size(289, 248);
            this.LikedPagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LikedPagePictureBox.TabIndex = 3;
            this.LikedPagePictureBox.TabStop = false;
            // 
            // LikedPagesListBox
            // 
            this.LikedPagesListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.LikedPagesListBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LikedPagesListBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LikedPagesListBox.FormattingEnabled = true;
            this.LikedPagesListBox.ItemHeight = 17;
            this.LikedPagesListBox.Location = new System.Drawing.Point(3, 6);
            this.LikedPagesListBox.Name = "LikedPagesListBox";
            this.LikedPagesListBox.Size = new System.Drawing.Size(240, 531);
            this.LikedPagesListBox.TabIndex = 0;
            this.LikedPagesListBox.SelectedIndexChanged += new System.EventHandler(this.LikedPagesListBox_SelectedIndexChanged);
            // 
            // AlbumsTab
            // 
            this.AlbumsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.AlbumsTab.Controls.Add(this.AlbumCoverPictureBox);
            this.AlbumsTab.Controls.Add(this.GoToAlbumButton);
            this.AlbumsTab.Controls.Add(this.AlbumsListBox);
            this.AlbumsTab.Location = new System.Drawing.Point(4, 24);
            this.AlbumsTab.Name = "AlbumsTab";
            this.AlbumsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AlbumsTab.Size = new System.Drawing.Size(548, 550);
            this.AlbumsTab.TabIndex = 1;
            this.AlbumsTab.Text = "Albums";
            // 
            // GoToAlbumButton
            // 
            this.GoToAlbumButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.GoToAlbumButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToAlbumButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GoToAlbumButton.Location = new System.Drawing.Point(252, 477);
            this.GoToAlbumButton.Name = "GoToAlbumButton";
            this.GoToAlbumButton.Size = new System.Drawing.Size(290, 60);
            this.GoToAlbumButton.TabIndex = 56;
            this.GoToAlbumButton.Text = "Display Album";
            this.GoToAlbumButton.UseVisualStyleBackColor = false;
            this.GoToAlbumButton.Click += new System.EventHandler(this.GoToAlbumButton_Click);
            // 
            // AlbumsListBox
            // 
            this.AlbumsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.AlbumsListBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumsListBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AlbumsListBox.FormattingEnabled = true;
            this.AlbumsListBox.ItemHeight = 17;
            this.AlbumsListBox.Location = new System.Drawing.Point(7, 6);
            this.AlbumsListBox.Name = "AlbumsListBox";
            this.AlbumsListBox.Size = new System.Drawing.Size(240, 531);
            this.AlbumsListBox.TabIndex = 0;
            this.AlbumsListBox.SelectedIndexChanged += new System.EventHandler(this.AlbumsListBox_SelectedIndexChanged);
            // 
            // FeedTab
            // 
            this.FeedTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.FeedTab.Controls.Add(this.PostPicture);
            this.FeedTab.Controls.Add(this.SelectedPostTextBox);
            this.FeedTab.Controls.Add(this.FeedListBox);
            this.FeedTab.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FeedTab.Location = new System.Drawing.Point(4, 24);
            this.FeedTab.Name = "FeedTab";
            this.FeedTab.Padding = new System.Windows.Forms.Padding(3);
            this.FeedTab.Size = new System.Drawing.Size(548, 550);
            this.FeedTab.TabIndex = 0;
            this.FeedTab.Text = "Feed";
            // 
            // PostPicture
            // 
            this.PostPicture.Location = new System.Drawing.Point(249, 247);
            this.PostPicture.Name = "PostPicture";
            this.PostPicture.Size = new System.Drawing.Size(290, 290);
            this.PostPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PostPicture.TabIndex = 2;
            this.PostPicture.TabStop = false;
            // 
            // SelectedPostTextBox
            // 
            this.SelectedPostTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.SelectedPostTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedPostTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SelectedPostTextBox.Location = new System.Drawing.Point(249, 6);
            this.SelectedPostTextBox.MaxLength = 3000;
            this.SelectedPostTextBox.Multiline = true;
            this.SelectedPostTextBox.Name = "SelectedPostTextBox";
            this.SelectedPostTextBox.ReadOnly = true;
            this.SelectedPostTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SelectedPostTextBox.Size = new System.Drawing.Size(290, 235);
            this.SelectedPostTextBox.TabIndex = 1;
            this.SelectedPostTextBox.Text = "Post Details ";
            // 
            // FeedListBox
            // 
            this.FeedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.FeedListBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedListBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FeedListBox.FormattingEnabled = true;
            this.FeedListBox.ItemHeight = 17;
            this.FeedListBox.Location = new System.Drawing.Point(3, 6);
            this.FeedListBox.Name = "FeedListBox";
            this.FeedListBox.Size = new System.Drawing.Size(240, 531);
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
            this.ControlTabs.Size = new System.Drawing.Size(556, 578);
            this.ControlTabs.TabIndex = 53;
            this.ControlTabs.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.ControlTabs_Selecting);
            // 
            // TaggedPicturesTab
            // 
            this.TaggedPicturesTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.TaggedPicturesTab.Controls.Add(this.GoToTaggedPicturePostButton);
            this.TaggedPicturesTab.Controls.Add(this.TaggedInPictureBox);
            this.TaggedPicturesTab.Controls.Add(this.TaggedPhotosListBox);
            this.TaggedPicturesTab.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaggedPicturesTab.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TaggedPicturesTab.Location = new System.Drawing.Point(4, 24);
            this.TaggedPicturesTab.Name = "TaggedPicturesTab";
            this.TaggedPicturesTab.Size = new System.Drawing.Size(548, 550);
            this.TaggedPicturesTab.TabIndex = 4;
            this.TaggedPicturesTab.Text = "Tagged Pictures";
            // 
            // GoToTaggedPicturePostButton
            // 
            this.GoToTaggedPicturePostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.GoToTaggedPicturePostButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToTaggedPicturePostButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GoToTaggedPicturePostButton.Location = new System.Drawing.Point(253, 477);
            this.GoToTaggedPicturePostButton.Name = "GoToTaggedPicturePostButton";
            this.GoToTaggedPicturePostButton.Size = new System.Drawing.Size(290, 60);
            this.GoToTaggedPicturePostButton.TabIndex = 53;
            this.GoToTaggedPicturePostButton.Text = "Go To Tagged Picture Post";
            this.GoToTaggedPicturePostButton.UseVisualStyleBackColor = false;
            this.GoToTaggedPicturePostButton.Click += new System.EventHandler(this.GoToTaggedPicturePostButton_Click);
            // 
            // TaggedInPictureBox
            // 
            this.TaggedInPictureBox.Image = global::BasicFacebookFeatures.Properties.Resources.No_Image_Available;
            this.TaggedInPictureBox.Location = new System.Drawing.Point(253, 3);
            this.TaggedInPictureBox.Name = "TaggedInPictureBox";
            this.TaggedInPictureBox.Size = new System.Drawing.Size(290, 290);
            this.TaggedInPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TaggedInPictureBox.TabIndex = 4;
            this.TaggedInPictureBox.TabStop = false;
            // 
            // TaggedPhotosListBox
            // 
            this.TaggedPhotosListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.TaggedPhotosListBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaggedPhotosListBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TaggedPhotosListBox.FormattingEnabled = true;
            this.TaggedPhotosListBox.ItemHeight = 17;
            this.TaggedPhotosListBox.Location = new System.Drawing.Point(7, 3);
            this.TaggedPhotosListBox.Name = "TaggedPhotosListBox";
            this.TaggedPhotosListBox.Size = new System.Drawing.Size(240, 531);
            this.TaggedPhotosListBox.TabIndex = 1;
            this.TaggedPhotosListBox.SelectedIndexChanged += new System.EventHandler(this.TaggedPhotosListBox_SelectedIndexChanged);
            // 
            // EventsTab
            // 
            this.EventsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.EventsTab.Controls.Add(this.EventTextBox);
            this.EventsTab.Controls.Add(this.EventPictureBox);
            this.EventsTab.Controls.Add(this.EventsListBox);
            this.EventsTab.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EventsTab.Location = new System.Drawing.Point(4, 24);
            this.EventsTab.Name = "EventsTab";
            this.EventsTab.Size = new System.Drawing.Size(548, 550);
            this.EventsTab.TabIndex = 5;
            this.EventsTab.Text = "Events";
            // 
            // EventTextBox
            // 
            this.EventTextBox.AcceptsReturn = true;
            this.EventTextBox.AcceptsTab = true;
            this.EventTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.EventTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EventTextBox.Location = new System.Drawing.Point(249, 3);
            this.EventTextBox.MaxLength = 5000;
            this.EventTextBox.Multiline = true;
            this.EventTextBox.Name = "EventTextBox";
            this.EventTextBox.ReadOnly = true;
            this.EventTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EventTextBox.Size = new System.Drawing.Size(292, 235);
            this.EventTextBox.TabIndex = 58;
            this.EventTextBox.Text = "Event Details";
            // 
            // EventPictureBox
            // 
            this.EventPictureBox.Image = global::BasicFacebookFeatures.Properties.Resources.No_Image_Available;
            this.EventPictureBox.Location = new System.Drawing.Point(249, 244);
            this.EventPictureBox.Name = "EventPictureBox";
            this.EventPictureBox.Size = new System.Drawing.Size(290, 290);
            this.EventPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EventPictureBox.TabIndex = 57;
            this.EventPictureBox.TabStop = false;
            // 
            // EventsListBox
            // 
            this.EventsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.EventsListBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventsListBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EventsListBox.FormattingEnabled = true;
            this.EventsListBox.ItemHeight = 17;
            this.EventsListBox.Location = new System.Drawing.Point(3, 3);
            this.EventsListBox.Name = "EventsListBox";
            this.EventsListBox.Size = new System.Drawing.Size(240, 531);
            this.EventsListBox.TabIndex = 2;
            this.EventsListBox.SelectedIndexChanged += new System.EventHandler(this.EventsListBox_SelectedIndexChanged);
            // 
            // FriendsTab
            // 
            this.FriendsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.FriendsTab.Controls.Add(this.BestFriendButton);
            this.FriendsTab.Controls.Add(this.FriendInfoTextBox);
            this.FriendsTab.Controls.Add(this.FriendPictureBox);
            this.FriendsTab.Controls.Add(this.FriendNameLabel);
            this.FriendsTab.Controls.Add(this.FriendsListBox);
            this.FriendsTab.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FriendsTab.Location = new System.Drawing.Point(4, 24);
            this.FriendsTab.Name = "FriendsTab";
            this.FriendsTab.Size = new System.Drawing.Size(548, 550);
            this.FriendsTab.TabIndex = 6;
            this.FriendsTab.Text = "Friends";
            // 
            // BestFriendButton
            // 
            this.BestFriendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.BestFriendButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BestFriendButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BestFriendButton.Location = new System.Drawing.Point(249, 477);
            this.BestFriendButton.Name = "BestFriendButton";
            this.BestFriendButton.Size = new System.Drawing.Size(290, 60);
            this.BestFriendButton.TabIndex = 60;
            this.BestFriendButton.Text = "Find Who Is Your Best Facebook Friend";
            this.BestFriendButton.UseVisualStyleBackColor = false;
            this.BestFriendButton.Click += new System.EventHandler(this.BestFriendButton_Click);
            // 
            // FriendInfoTextBox
            // 
            this.FriendInfoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.FriendInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FriendInfoTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendInfoTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FriendInfoTextBox.Location = new System.Drawing.Point(249, 323);
            this.FriendInfoTextBox.Multiline = true;
            this.FriendInfoTextBox.Name = "FriendInfoTextBox";
            this.FriendInfoTextBox.ReadOnly = true;
            this.FriendInfoTextBox.Size = new System.Drawing.Size(290, 175);
            this.FriendInfoTextBox.TabIndex = 59;
            this.FriendInfoTextBox.Text = "Friend Info";
            // 
            // FriendPictureBox
            // 
            this.FriendPictureBox.Image = global::BasicFacebookFeatures.Properties.Resources.Unknown_Profile_Picture;
            this.FriendPictureBox.Location = new System.Drawing.Point(249, 27);
            this.FriendPictureBox.Name = "FriendPictureBox";
            this.FriendPictureBox.Size = new System.Drawing.Size(290, 290);
            this.FriendPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FriendPictureBox.TabIndex = 58;
            this.FriendPictureBox.TabStop = false;
            // 
            // FriendNameLabel
            // 
            this.FriendNameLabel.AutoSize = true;
            this.FriendNameLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendNameLabel.Location = new System.Drawing.Point(249, 3);
            this.FriendNameLabel.Name = "FriendNameLabel";
            this.FriendNameLabel.Size = new System.Drawing.Size(59, 24);
            this.FriendNameLabel.TabIndex = 57;
            this.FriendNameLabel.Text = "Name";
            // 
            // FriendsListBox
            // 
            this.FriendsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.FriendsListBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendsListBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FriendsListBox.FormattingEnabled = true;
            this.FriendsListBox.ItemHeight = 17;
            this.FriendsListBox.Location = new System.Drawing.Point(3, 3);
            this.FriendsListBox.Name = "FriendsListBox";
            this.FriendsListBox.Size = new System.Drawing.Size(240, 531);
            this.FriendsListBox.TabIndex = 3;
            this.FriendsListBox.SelectedIndexChanged += new System.EventHandler(this.FriendsListBox_SelectedIndexChanged);
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Image = global::BasicFacebookFeatures.Properties.Resources.Unknown_Profile_Picture;
            this.ProfilePicture.Location = new System.Drawing.Point(567, 23);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(250, 250);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePicture.TabIndex = 55;
            this.ProfilePicture.TabStop = false;
            // 
            // UserInfoTextBox
            // 
            this.UserInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserInfoTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInfoTextBox.Location = new System.Drawing.Point(567, 279);
            this.UserInfoTextBox.Multiline = true;
            this.UserInfoTextBox.Name = "UserInfoTextBox";
            this.UserInfoTextBox.ReadOnly = true;
            this.UserInfoTextBox.Size = new System.Drawing.Size(250, 85);
            this.UserInfoTextBox.TabIndex = 56;
            this.UserInfoTextBox.Text = "User Info";
            // 
            // PostStatusButton
            // 
            this.PostStatusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.PostStatusButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostStatusButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PostStatusButton.Location = new System.Drawing.Point(567, 479);
            this.PostStatusButton.Name = "PostStatusButton";
            this.PostStatusButton.Size = new System.Drawing.Size(250, 30);
            this.PostStatusButton.TabIndex = 57;
            this.PostStatusButton.Text = "Post Status";
            this.PostStatusButton.UseVisualStyleBackColor = false;
            this.PostStatusButton.Click += new System.EventHandler(this.PostStatusButton_Click);
            // 
            // StatusRichTextBox
            // 
            this.StatusRichTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusRichTextBox.Location = new System.Drawing.Point(567, 370);
            this.StatusRichTextBox.Name = "StatusRichTextBox";
            this.StatusRichTextBox.Size = new System.Drawing.Size(250, 103);
            this.StatusRichTextBox.TabIndex = 58;
            this.StatusRichTextBox.Text = "";
            // 
            // ResumeBuilderButton
            // 
            this.ResumeBuilderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ResumeBuilderButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResumeBuilderButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ResumeBuilderButton.Location = new System.Drawing.Point(567, 551);
            this.ResumeBuilderButton.Name = "ResumeBuilderButton";
            this.ResumeBuilderButton.Size = new System.Drawing.Size(250, 30);
            this.ResumeBuilderButton.TabIndex = 59;
            this.ResumeBuilderButton.Text = "Facebook Resume Builder";
            this.ResumeBuilderButton.UseVisualStyleBackColor = false;
            this.ResumeBuilderButton.Click += new System.EventHandler(this.ResumeBuilderButton_Click);
            // 
            // AlbumCoverPictureBox
            // 
            this.AlbumCoverPictureBox.Location = new System.Drawing.Point(252, 6);
            this.AlbumCoverPictureBox.Name = "AlbumCoverPictureBox";
            this.AlbumCoverPictureBox.Size = new System.Drawing.Size(290, 290);
            this.AlbumCoverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AlbumCoverPictureBox.TabIndex = 57;
            this.AlbumCoverPictureBox.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(829, 584);
            this.Controls.Add(this.ResumeBuilderButton);
            this.Controls.Add(this.StatusRichTextBox);
            this.Controls.Add(this.PostStatusButton);
            this.Controls.Add(this.UserInfoTextBox);
            this.Controls.Add(this.ProfilePicture);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ControlTabs);
            this.Controls.Add(this.SwitchLogoutButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::BasicFacebookFeatures.Properties.Resources.facebook_icon;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook App DP";
            this.GroupsTab.ResumeLayout(false);
            this.GroupsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupPictureBox)).EndInit();
            this.LikedPagesTab.ResumeLayout(false);
            this.LikedPagesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LikedPagePictureBox)).EndInit();
            this.AlbumsTab.ResumeLayout(false);
            this.FeedTab.ResumeLayout(false);
            this.FeedTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PostPicture)).EndInit();
            this.ControlTabs.ResumeLayout(false);
            this.TaggedPicturesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TaggedInPictureBox)).EndInit();
            this.EventsTab.ResumeLayout(false);
            this.EventsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventPictureBox)).EndInit();
            this.FriendsTab.ResumeLayout(false);
            this.FriendsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FriendPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumCoverPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.Button SwitchLogoutButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TabPage GroupsTab;
        private System.Windows.Forms.TabPage LikedPagesTab;
        private System.Windows.Forms.TabPage AlbumsTab;
        private System.Windows.Forms.TabPage FeedTab;
        private System.Windows.Forms.TabControl ControlTabs;
        private System.Windows.Forms.PictureBox ProfilePicture;
        private System.Windows.Forms.ListBox FeedListBox;
        private System.Windows.Forms.TextBox SelectedPostTextBox;
        private System.Windows.Forms.PictureBox PostPicture;
        private System.Windows.Forms.ListBox AlbumsListBox;
        private System.Windows.Forms.Button GoToAlbumButton;
        private System.Windows.Forms.ListBox LikedPagesListBox;
        private System.Windows.Forms.ListBox GroupsListBox;
        private System.Windows.Forms.PictureBox GroupPictureBox;
        private System.Windows.Forms.TextBox GroupInfoTextBox;
        private System.Windows.Forms.PictureBox LikedPagePictureBox;
        private System.Windows.Forms.TabPage TaggedPicturesTab;
        private System.Windows.Forms.PictureBox TaggedInPictureBox;
        private System.Windows.Forms.ListBox TaggedPhotosListBox;
        private System.Windows.Forms.Button GoToTaggedPicturePostButton;
        private System.Windows.Forms.Button GoToPageButton;
        private System.Windows.Forms.TextBox LikedPageDetailsTextBox;
        private System.Windows.Forms.TextBox UserInfoTextBox;
        private System.Windows.Forms.TabPage EventsTab;
        private System.Windows.Forms.ListBox EventsListBox;
        private System.Windows.Forms.PictureBox EventPictureBox;
        private System.Windows.Forms.TextBox EventTextBox;
        private System.Windows.Forms.Button PostStatusButton;
        private System.Windows.Forms.RichTextBox StatusRichTextBox;
        private System.Windows.Forms.TabPage FriendsTab;
        private System.Windows.Forms.TextBox FriendInfoTextBox;
        private System.Windows.Forms.PictureBox FriendPictureBox;
        private System.Windows.Forms.Label FriendNameLabel;
        private System.Windows.Forms.ListBox FriendsListBox;
        private System.Windows.Forms.Button BestFriendButton;
        private System.Windows.Forms.Button ResumeBuilderButton;
        private System.Windows.Forms.PictureBox AlbumCoverPictureBox;
    }
}

