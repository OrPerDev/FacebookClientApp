using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookAppLogic;
using System.Reflection;
using System.Collections.Generic;

namespace FacebookAppClient
{
    public partial class ResumeBuilderForm : Form
    {
        private readonly FacebookResumeUser r_CurrentUser;

        public ResumeBuilderForm(User io_CurrentUser)
        {
            this.r_CurrentUser = new FacebookResumeUser(io_CurrentUser);
            InitializeComponent();
            this.getProxyUserPropertiesToBind();
        }

        private void getProxyUserPropertiesToBind()
        {
            foreach (PropertyInfo propertyInfo in this.r_CurrentUser.GetType().GetProperties())
            {
                if (propertyInfo.PropertyType == typeof(List<string>))
                {
                    this.InfoSelectorComboBox.Items.Add(propertyInfo.Name);
                }
            }
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

        private void AddInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedSection = this.InfoSelectorComboBox.SelectedItem as string;
                PropertyInfo selectedSectionPropertyInfo = this.r_CurrentUser.GetType().GetProperty(selectedSection);
                if (selectedSectionPropertyInfo.PropertyType == typeof(List<string>))
                {
                    List<string> listProperty = selectedSectionPropertyInfo.GetValue(this.r_CurrentUser) as List<string>;
                    if (!string.IsNullOrEmpty(this.InfoAddTextBox.Text))
                    {
                        listProperty.Add(this.InfoAddTextBox.Text);
                        this.ResumeTextBox.Text = FacebookResumeBuilder.GenerateUserResume(this.r_CurrentUser);
                    }
                    else
                    {
                        throw new Exception("You did add any information text to add to the section, Please add information.");
                    }
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("You must select a section to add info to", "Facebook Resume Builder - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Facebook Resume Builder - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void AddIntroductionButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.IntroductionTextBox.Text))
                {
                    this.r_CurrentUser.Introduction = this.IntroductionTextBox.Text;
                    this.ResumeTextBox.Text = FacebookResumeBuilder.GenerateUserResume(this.r_CurrentUser);
                }
                else
                {
                    throw new Exception("You did add any information text to add to the introduction, Please add information.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Facebook Resume Builder - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
