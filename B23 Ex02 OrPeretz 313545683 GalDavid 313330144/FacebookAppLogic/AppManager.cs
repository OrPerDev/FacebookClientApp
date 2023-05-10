using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookAppLogic
{
    public sealed class AppManager
    {
        private static readonly string sr_AppID = "117840964538971";
        private readonly AppSettings r_UsersSettings = AppSettings.Instance;

        public User LoggedInUser { get; set; }

        private AppManager()
        {
            this.LoggedInUser = null;
            if (this.AreUsersExistsOnDB())
            {
                this.removeAllOldAccessTokens();
            }
        }

        public static AppManager Instance
        {
            get
            {
                return Singleton<AppManager>.Instance;
            }
        }

        public AppSettings AppUsersSettings
        {
            get
            {
                return this.r_UsersSettings;
            }
        }

        public bool IsUserLogged()
        {
            return this.LoggedInUser != null;
        }

        private void setCurrentUser(User i_CurrentUser)
        {
            this.LoggedInUser = i_CurrentUser;
        }

        private void removeAllOldAccessTokens()
        {
            List<UserSerializationData> serializationDatasToRemove = new List<UserSerializationData>();
            foreach (UserSerializationData userSerializationData in this.r_UsersSettings.UsersSerializationData)
            {
                if (userSerializationData.TokenCreationTime.AddDays(60) < DateTime.Now)
                {
                    serializationDatasToRemove.Add(userSerializationData);
                }
            }

            foreach (UserSerializationData userSerializationData in serializationDatasToRemove)
            {
                this.r_UsersSettings.UsersSerializationData.Remove(userSerializationData);
            }

            this.r_UsersSettings.SaveUsersToDB();
        }

        public bool AreUsersExistsOnDB()
        {
            return this.r_UsersSettings.UsersSerializationData.Count > 0;
        }

        public void removeUserFromDB(string i_UserAccessToken)
        {
            UserSerializationData userToRemove = this.AppUsersSettings.UsersSerializationData.First(data => data.AccessToken == i_UserAccessToken);
            this.AppUsersSettings.UsersSerializationData.Remove(userToRemove);
            this.r_UsersSettings.SaveUsersToDB();
            this.r_UsersSettings.ReloadUsersList();
        }

        public void LoginToFacebook(string i_UserAccessToken)
        {
            LoginResult loginResult = null;
            if (string.IsNullOrEmpty(i_UserAccessToken))
            {
                loginResult = this.newLoginToFacebook();
            }
            else
            {
                loginResult = FacebookService.Connect(i_UserAccessToken);
            }

            if (string.IsNullOrEmpty(i_UserAccessToken) && loginResult.AccessToken != null)
            {
                if (this.AppUsersSettings.isUserNameAlreadyInDB(loginResult.LoggedInUser.Name))
                {
                    this.AppUsersSettings.updateUserAccessToken(loginResult.LoggedInUser.Name, loginResult.AccessToken);
                }
                else
                {
                    this.r_UsersSettings.UsersSerializationData.Add(new UserSerializationData(loginResult.AccessToken, loginResult.LoggedInUser.Name, DateTime.Now));
                }
            }

            this.setCurrentUser(loginResult.LoggedInUser);
        }

        private LoginResult newLoginToFacebook()
        {
            return FacebookService.Login(
                sr_AppID,
                "email",
                "user_likes",
                "user_posts",
                "user_link",
                "user_photos",
                "user_events",
                "user_videos",
                "user_gender",
                "user_friends",
                "user_hometown",
                "user_location",
                "user_birthday",
                "public_profile",
                "user_age_range",
                "pages_read_engagement",
                "pages_manage_metadata",
                "groups_access_member_info",
                "page_events",
                "pages_read_user_content",
                "publish_to_groups",
                "pages_manage_posts");
        }

        public void LogoutFromFacebook(string io_AccessToken)
        {
            FacebookService.Logout(i_AccessToken: io_AccessToken);
            this.setCurrentUser(null);
        }

        public string FetchUserProfilePictureURL(User i_UserToFetchFrom)
        {
            return i_UserToFetchFrom.PictureLargeURL != null ? i_UserToFetchFrom.PictureLargeURL : null;
        }

        public string FetchUserInfo(User i_UserToFetchFrom)
        {
            StringBuilder userInfo = new StringBuilder();
            userInfo.AppendLine($"• Birthday - {i_UserToFetchFrom.Birthday}");
            userInfo.AppendLine($"• Gender - {i_UserToFetchFrom.Gender}");
            userInfo.AppendLine($"• Email - {i_UserToFetchFrom.Email}");
            userInfo.AppendLine($"• Lives in - {i_UserToFetchFrom.Location.Name}");
            return userInfo.ToString();
        }
    }
}
