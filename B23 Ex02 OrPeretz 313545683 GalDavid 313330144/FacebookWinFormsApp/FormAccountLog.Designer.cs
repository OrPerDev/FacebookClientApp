
namespace BasicFacebookFeatures
{
    partial class FormAccountLog
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.UsersListBox = new System.Windows.Forms.ListBox();
            this.LogoutAccountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginButton.Location = new System.Drawing.Point(12, 387);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(274, 43);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login to Facebook";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UsersListBox
            // 
            this.UsersListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.UsersListBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersListBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UsersListBox.FormattingEnabled = true;
            this.UsersListBox.ItemHeight = 17;
            this.UsersListBox.Location = new System.Drawing.Point(12, 12);
            this.UsersListBox.Name = "UsersListBox";
            this.UsersListBox.Size = new System.Drawing.Size(274, 361);
            this.UsersListBox.TabIndex = 1;
            this.UsersListBox.SelectedIndexChanged += new System.EventHandler(this.PreviousUsersListBox_SelectedIndexChanged);
            // 
            // LogoutAccountButton
            // 
            this.LogoutAccountButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutAccountButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LogoutAccountButton.Location = new System.Drawing.Point(12, 436);
            this.LogoutAccountButton.Name = "LogoutAccountButton";
            this.LogoutAccountButton.Size = new System.Drawing.Size(274, 43);
            this.LogoutAccountButton.TabIndex = 2;
            this.LogoutAccountButton.Text = "Logout Selected Account";
            this.LogoutAccountButton.UseVisualStyleBackColor = false;
            this.LogoutAccountButton.Click += new System.EventHandler(this.LogoutAccountButton_Click);
            // 
            // FormAccountLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(298, 497);
            this.Controls.Add(this.LogoutAccountButton);
            this.Controls.Add(this.UsersListBox);
            this.Controls.Add(this.LoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::BasicFacebookFeatures.Properties.Resources.facebook_icon;
            this.MaximizeBox = false;
            this.Name = "FormAccountLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login to facebook";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.ListBox UsersListBox;
        private System.Windows.Forms.Button LogoutAccountButton;
    }
}