
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
            this.SuspendLayout();
            // 
            // BuildResumeButton
            // 
            this.BuildResumeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.BuildResumeButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildResumeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BuildResumeButton.Location = new System.Drawing.Point(12, 519);
            this.BuildResumeButton.Name = "BuildResumeButton";
            this.BuildResumeButton.Size = new System.Drawing.Size(360, 30);
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
            this.ResumeTextBox.Size = new System.Drawing.Size(360, 501);
            this.ResumeTextBox.TabIndex = 61;
            this.ResumeTextBox.Text = "Once you press the build my resume button the resume text will appear here!";
            // 
            // ResumeBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.ResumeTextBox);
            this.Controls.Add(this.BuildResumeButton);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
    }
}