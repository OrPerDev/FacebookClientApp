using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookAppLogic;

namespace FacebookAppClient
{
    public partial class FormAccountLog : Form
    {
        private readonly AppManager r_AppManager = AppManager.Instance;

        public FormAccountLog()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.poplateUsersList();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            int indexOfSelectedItem = this.UsersListBox.SelectedIndex;
            string userAccessToken = this.r_AppManager.AppUsersSettings.UsersSerializationData.Count == indexOfSelectedItem
                ? null : this.r_AppManager.AppUsersSettings.UsersSerializationData[indexOfSelectedItem].AccessToken;
            try
            {
                if (this.r_AppManager.IsUserLogged() && userAccessToken == null)
                {
                    this.r_AppManager.LogoutFromFacebook(this.r_AppManager.AppUsersSettings.UsersSerializationData.Find(serialzation => serialzation.UserName == this.r_AppManager.LoggedInUser.Name).AccessToken);
                }

                this.r_AppManager.LoginToFacebook(userAccessToken);
                this.r_AppManager.AppUsersSettings.SaveUsersToDB();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error logging-in to Facebook, Please try again - Error - {ex.Message}", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void poplateUsersList()
        {
            if (this.r_AppManager.AreUsersExistsOnDB())
            {
                List<string> previousConnectedUsersList = new List<string>();
                foreach (UserSerializationData userSerialization in this.r_AppManager.AppUsersSettings.UsersSerializationData)
                {
                    previousConnectedUsersList.Add(userSerialization.UserName);
                }

                previousConnectedUsersList.Add("Connect new user.");
                this.UsersListBox.DataSource = previousConnectedUsersList;
            }
            else
            {
                this.UsersListBox.DataSource = new List<string> { "Connect new user." };
            }
        }

        private void PreviousUsersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentSelection = (sender as ListBox).SelectedItem.ToString();

            if (currentSelection == "Connect new user.")
            {
                this.LogoutAccountButton.Enabled = false;
            }
            else
            {
                this.LogoutAccountButton.Enabled = true;
            }
        }

        private void LogoutAccountButton_Click(object sender, EventArgs e)
        {
            int indexOfSelectedItem = this.UsersListBox.SelectedIndex;
            string userAccessToken = this.r_AppManager.AppUsersSettings.UsersSerializationData.Count == indexOfSelectedItem
                ? null : this.r_AppManager.AppUsersSettings.UsersSerializationData[indexOfSelectedItem].AccessToken;
            this.r_AppManager.removeUserFromDB(userAccessToken);
            this.r_AppManager.LogoutFromFacebook(userAccessToken);
            this.poplateUsersList();
        }
    }
}
