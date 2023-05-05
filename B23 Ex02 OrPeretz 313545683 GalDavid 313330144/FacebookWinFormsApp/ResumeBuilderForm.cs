using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookAppLogic;

namespace FacebookAppClient
{
    public partial class ResumeBuilderForm : Form
    {
        private readonly User r_CurrentUser;

        public ResumeBuilderForm(User i_CurrentUser)
        {
            this.r_CurrentUser = i_CurrentUser;
            InitializeComponent();
        }

        private void BuildResumeButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Facebook Resume Builder - Generating resume";
                this.ResumeTextBox.Text = FacebookResumeBuilder.GenerateUserResume(this.r_CurrentUser);
                this.Text = "Facebook Resume Builder";
            }
            catch (Exception ex)
            {
                this.Text = "Facebook Resume Builder";
                MessageBox.Show(ex.Message, "Facebook Resume Builder - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
