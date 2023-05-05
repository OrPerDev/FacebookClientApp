
namespace FacebookAppClient
{
    partial class AlbumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumForm));
            this.LeftArrowPictureBox = new System.Windows.Forms.PictureBox();
            this.RightArrowPictureBox = new System.Windows.Forms.PictureBox();
            this.CurrentPictureBox = new System.Windows.Forms.PictureBox();
            this.PictureLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ButtonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrowPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightArrowPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftArrowPictureBox
            // 
            this.LeftArrowPictureBox.Image = global::FacebookAppClient.Properties.Resources.White_Left_Arrow;
            this.LeftArrowPictureBox.Location = new System.Drawing.Point(12, 393);
            this.LeftArrowPictureBox.Name = "LeftArrowPictureBox";
            this.LeftArrowPictureBox.Size = new System.Drawing.Size(155, 60);
            this.LeftArrowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftArrowPictureBox.TabIndex = 3;
            this.LeftArrowPictureBox.TabStop = false;
            this.LeftArrowPictureBox.Click += new System.EventHandler(this.LeftArrowPictureBox_Click);
            // 
            // RightArrowPictureBox
            // 
            this.RightArrowPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RightArrowPictureBox.Image")));
            this.RightArrowPictureBox.Location = new System.Drawing.Point(177, 393);
            this.RightArrowPictureBox.Name = "RightArrowPictureBox";
            this.RightArrowPictureBox.Size = new System.Drawing.Size(155, 60);
            this.RightArrowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RightArrowPictureBox.TabIndex = 2;
            this.RightArrowPictureBox.TabStop = false;
            this.RightArrowPictureBox.Click += new System.EventHandler(this.RightArrowPictureBox_Click);
            // 
            // CurrentPictureBox
            // 
            this.CurrentPictureBox.Location = new System.Drawing.Point(12, 54);
            this.CurrentPictureBox.Name = "CurrentPictureBox";
            this.CurrentPictureBox.Size = new System.Drawing.Size(320, 320);
            this.CurrentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CurrentPictureBox.TabIndex = 0;
            this.CurrentPictureBox.TabStop = false;
            // 
            // PictureLinkLabel
            // 
            this.PictureLinkLabel.AutoSize = true;
            this.PictureLinkLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PictureLinkLabel.LinkColor = System.Drawing.SystemColors.ButtonFace;
            this.PictureLinkLabel.Location = new System.Drawing.Point(12, 24);
            this.PictureLinkLabel.Name = "PictureLinkLabel";
            this.PictureLinkLabel.Size = new System.Drawing.Size(222, 24);
            this.PictureLinkLabel.TabIndex = 4;
            this.PictureLinkLabel.TabStop = true;
            this.PictureLinkLabel.Text = "Watch Picture On Browser";
            this.PictureLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PictureLinkLabel_LinkClicked);
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ButtonBack.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonBack.Location = new System.Drawing.Point(77, 459);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(170, 30);
            this.ButtonBack.TabIndex = 53;
            this.ButtonBack.Text = "Back To Main Screen";
            this.ButtonBack.UseVisualStyleBackColor = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // AlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(349, 501);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.PictureLinkLabel);
            this.Controls.Add(this.LeftArrowPictureBox);
            this.Controls.Add(this.RightArrowPictureBox);
            this.Controls.Add(this.CurrentPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::FacebookAppClient.Properties.Resources.facebook_icon;
            this.MaximizeBox = false;
            this.Name = "AlbumForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlbumForm";
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrowPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightArrowPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CurrentPictureBox;
        private System.Windows.Forms.PictureBox RightArrowPictureBox;
        private System.Windows.Forms.PictureBox LeftArrowPictureBox;
        private System.Windows.Forms.LinkLabel PictureLinkLabel;
        private System.Windows.Forms.Button ButtonBack;
    }
}