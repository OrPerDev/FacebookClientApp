
namespace FacebookAppClient
{
    partial class ResumeBuilderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResumeBuilderForm));
            this.BuildResumeButton = new System.Windows.Forms.Button();
            this.ResumeTextBox = new System.Windows.Forms.TextBox();
            this.InfoToAddLabel = new System.Windows.Forms.Label();
            this.InfoAddTextBox = new System.Windows.Forms.TextBox();
            this.AddInfoButton = new System.Windows.Forms.Button();
            this.AdditionalInfoLabel = new System.Windows.Forms.Label();
            this.InfoSelectorComboBox = new System.Windows.Forms.ComboBox();
            this.SectionToAddLabel = new System.Windows.Forms.Label();
            this.AddIntroductionButton = new System.Windows.Forms.Button();
            this.IntroductionTextBox = new System.Windows.Forms.TextBox();
            this.IntroductionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BuildResumeButton
            // 
            this.BuildResumeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.BuildResumeButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildResumeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BuildResumeButton.Location = new System.Drawing.Point(11, 585);
            this.BuildResumeButton.Name = "BuildResumeButton";
            this.BuildResumeButton.Size = new System.Drawing.Size(420, 34);
            this.BuildResumeButton.TabIndex = 60;
            this.BuildResumeButton.Text = "Build My Resume!";
            this.BuildResumeButton.UseVisualStyleBackColor = false;
            this.BuildResumeButton.Click += new System.EventHandler(this.BuildResumeButton_Click);
            // 
            // ResumeTextBox
            // 
            this.ResumeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ResumeTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResumeTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ResumeTextBox.Location = new System.Drawing.Point(12, 12);
            this.ResumeTextBox.Multiline = true;
            this.ResumeTextBox.Name = "ResumeTextBox";
            this.ResumeTextBox.ReadOnly = true;
            this.ResumeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResumeTextBox.Size = new System.Drawing.Size(419, 567);
            this.ResumeTextBox.TabIndex = 61;
            this.ResumeTextBox.Text = resources.GetString("ResumeTextBox.Text");
            // 
            // InfoToAddLabel
            // 
            this.InfoToAddLabel.AutoSize = true;
            this.InfoToAddLabel.Location = new System.Drawing.Point(437, 38);
            this.InfoToAddLabel.Name = "InfoToAddLabel";
            this.InfoToAddLabel.Size = new System.Drawing.Size(76, 17);
            this.InfoToAddLabel.TabIndex = 62;
            this.InfoToAddLabel.Text = "Info To Add :";
            // 
            // InfoAddTextBox
            // 
            this.InfoAddTextBox.Location = new System.Drawing.Point(437, 58);
            this.InfoAddTextBox.Multiline = true;
            this.InfoAddTextBox.Name = "InfoAddTextBox";
            this.InfoAddTextBox.Size = new System.Drawing.Size(326, 133);
            this.InfoAddTextBox.TabIndex = 63;
            // 
            // AddInfoButton
            // 
            this.AddInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.AddInfoButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddInfoButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddInfoButton.Location = new System.Drawing.Point(437, 245);
            this.AddInfoButton.Name = "AddInfoButton";
            this.AddInfoButton.Size = new System.Drawing.Size(326, 34);
            this.AddInfoButton.TabIndex = 64;
            this.AddInfoButton.Text = "Add New Infotmation To Selected Section";
            this.AddInfoButton.UseVisualStyleBackColor = false;
            this.AddInfoButton.Click += new System.EventHandler(this.AddInfoButton_Click);
            // 
            // AdditionalInfoLabel
            // 
            this.AdditionalInfoLabel.AutoSize = true;
            this.AdditionalInfoLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionalInfoLabel.Location = new System.Drawing.Point(437, 12);
            this.AdditionalInfoLabel.Name = "AdditionalInfoLabel";
            this.AdditionalInfoLabel.Size = new System.Drawing.Size(211, 26);
            this.AdditionalInfoLabel.TabIndex = 65;
            this.AdditionalInfoLabel.Text = "Additional information";
            // 
            // InfoSelectorComboBox
            // 
            this.InfoSelectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InfoSelectorComboBox.FormattingEnabled = true;
            this.InfoSelectorComboBox.Location = new System.Drawing.Point(437, 214);
            this.InfoSelectorComboBox.Name = "InfoSelectorComboBox";
            this.InfoSelectorComboBox.Size = new System.Drawing.Size(326, 25);
            this.InfoSelectorComboBox.TabIndex = 66;
            // 
            // SectionToAddLabel
            // 
            this.SectionToAddLabel.AutoSize = true;
            this.SectionToAddLabel.Location = new System.Drawing.Point(437, 194);
            this.SectionToAddLabel.Name = "SectionToAddLabel";
            this.SectionToAddLabel.Size = new System.Drawing.Size(140, 17);
            this.SectionToAddLabel.TabIndex = 67;
            this.SectionToAddLabel.Text = "Section To Add The Info:";
            // 
            // AddIntroductionButton
            // 
            this.AddIntroductionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.AddIntroductionButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddIntroductionButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddIntroductionButton.Location = new System.Drawing.Point(437, 585);
            this.AddIntroductionButton.Name = "AddIntroductionButton";
            this.AddIntroductionButton.Size = new System.Drawing.Size(326, 34);
            this.AddIntroductionButton.TabIndex = 70;
            this.AddIntroductionButton.Text = "Add Introduction";
            this.AddIntroductionButton.UseVisualStyleBackColor = false;
            this.AddIntroductionButton.Click += new System.EventHandler(this.AddIntroductionButton_Click);
            // 
            // IntroductionTextBox
            // 
            this.IntroductionTextBox.Location = new System.Drawing.Point(437, 309);
            this.IntroductionTextBox.Multiline = true;
            this.IntroductionTextBox.Name = "IntroductionTextBox";
            this.IntroductionTextBox.Size = new System.Drawing.Size(326, 270);
            this.IntroductionTextBox.TabIndex = 69;
            // 
            // IntroductionLabel
            // 
            this.IntroductionLabel.AutoSize = true;
            this.IntroductionLabel.Location = new System.Drawing.Point(437, 289);
            this.IntroductionLabel.Name = "IntroductionLabel";
            this.IntroductionLabel.Size = new System.Drawing.Size(189, 17);
            this.IntroductionLabel.TabIndex = 68;
            this.IntroductionLabel.Text = "Add Introduction About Yourself :";
            // 
            // ResumeBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(778, 636);
            this.Controls.Add(this.AddIntroductionButton);
            this.Controls.Add(this.IntroductionTextBox);
            this.Controls.Add(this.IntroductionLabel);
            this.Controls.Add(this.SectionToAddLabel);
            this.Controls.Add(this.InfoSelectorComboBox);
            this.Controls.Add(this.AdditionalInfoLabel);
            this.Controls.Add(this.AddInfoButton);
            this.Controls.Add(this.InfoAddTextBox);
            this.Controls.Add(this.InfoToAddLabel);
            this.Controls.Add(this.ResumeTextBox);
            this.Controls.Add(this.BuildResumeButton);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "ResumeBuilderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Resume Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuildResumeButton;
        private System.Windows.Forms.TextBox ResumeTextBox;
        private System.Windows.Forms.Label InfoToAddLabel;
        private System.Windows.Forms.TextBox InfoAddTextBox;
        private System.Windows.Forms.Button AddInfoButton;
        private System.Windows.Forms.Label AdditionalInfoLabel;
        private System.Windows.Forms.ComboBox InfoSelectorComboBox;
        private System.Windows.Forms.Label SectionToAddLabel;
        private System.Windows.Forms.Button AddIntroductionButton;
        private System.Windows.Forms.TextBox IntroductionTextBox;
        private System.Windows.Forms.Label IntroductionLabel;
    }
}