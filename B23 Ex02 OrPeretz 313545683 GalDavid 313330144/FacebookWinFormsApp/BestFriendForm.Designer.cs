
namespace BasicFacebookFeatures
{
    partial class BestFriendForm
    {
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
            this.FriendInfoTextBox = new System.Windows.Forms.TextBox();
            this.FriendPictureBox = new System.Windows.Forms.PictureBox();
            this.FriendNameLabel = new System.Windows.Forms.Label();
            this.FindBestFriendButton = new System.Windows.Forms.Button();
            this.GoToFriendProfileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FriendPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FriendInfoTextBox
            // 
            this.FriendInfoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.FriendInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FriendInfoTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendInfoTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FriendInfoTextBox.Location = new System.Drawing.Point(268, 33);
            this.FriendInfoTextBox.Multiline = true;
            this.FriendInfoTextBox.Name = "FriendInfoTextBox";
            this.FriendInfoTextBox.ReadOnly = true;
            this.FriendInfoTextBox.Size = new System.Drawing.Size(250, 183);
            this.FriendInfoTextBox.TabIndex = 62;
            this.FriendInfoTextBox.Text = "Friend Info - Your friend Info will appear here";
            // 
            // FriendPictureBox
            // 
            this.FriendPictureBox.Image = global::BasicFacebookFeatures.Properties.Resources.Unknown_Profile_Picture;
            this.FriendPictureBox.Location = new System.Drawing.Point(12, 33);
            this.FriendPictureBox.Name = "FriendPictureBox";
            this.FriendPictureBox.Size = new System.Drawing.Size(250, 255);
            this.FriendPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FriendPictureBox.TabIndex = 61;
            this.FriendPictureBox.TabStop = false;
            // 
            // FriendNameLabel
            // 
            this.FriendNameLabel.AutoSize = true;
            this.FriendNameLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FriendNameLabel.Location = new System.Drawing.Point(12, 9);
            this.FriendNameLabel.Name = "FriendNameLabel";
            this.FriendNameLabel.Size = new System.Drawing.Size(59, 24);
            this.FriendNameLabel.TabIndex = 60;
            this.FriendNameLabel.Text = "Name";
            // 
            // FindBestFriendButton
            // 
            this.FindBestFriendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.FindBestFriendButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindBestFriendButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FindBestFriendButton.Location = new System.Drawing.Point(268, 222);
            this.FindBestFriendButton.Name = "FindBestFriendButton";
            this.FindBestFriendButton.Size = new System.Drawing.Size(250, 30);
            this.FindBestFriendButton.TabIndex = 63;
            this.FindBestFriendButton.Text = "Find Who Is Your Best Friend!";
            this.FindBestFriendButton.UseVisualStyleBackColor = false;
            this.FindBestFriendButton.Click += new System.EventHandler(this.FindBestFriendButton_Click);
            // 
            // GoToFriendProfileButton
            // 
            this.GoToFriendProfileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.GoToFriendProfileButton.Enabled = false;
            this.GoToFriendProfileButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToFriendProfileButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GoToFriendProfileButton.Location = new System.Drawing.Point(268, 258);
            this.GoToFriendProfileButton.Name = "GoToFriendProfileButton";
            this.GoToFriendProfileButton.Size = new System.Drawing.Size(250, 30);
            this.GoToFriendProfileButton.TabIndex = 64;
            this.GoToFriendProfileButton.Text = "Go To Friend\'s Profile";
            this.GoToFriendProfileButton.UseVisualStyleBackColor = false;
            this.GoToFriendProfileButton.Click += new System.EventHandler(this.GoToFriendProfileButton_Click);
            // 
            // BestFriendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(532, 306);
            this.Controls.Add(this.GoToFriendProfileButton);
            this.Controls.Add(this.FindBestFriendButton);
            this.Controls.Add(this.FriendInfoTextBox);
            this.Controls.Add(this.FriendPictureBox);
            this.Controls.Add(this.FriendNameLabel);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "BestFriendForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Best Friend";
            this.Icon = Properties.Resources.facebook_icon;
            ((System.ComponentModel.ISupportInitialize)(this.FriendPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FriendInfoTextBox;
        private System.Windows.Forms.PictureBox FriendPictureBox;
        private System.Windows.Forms.Label FriendNameLabel;
        private System.Windows.Forms.Button FindBestFriendButton;
        private System.Windows.Forms.Button GoToFriendProfileButton;
    }
}