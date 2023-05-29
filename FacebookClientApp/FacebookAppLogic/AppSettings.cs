using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace FacebookAppLogic
{
    public sealed class AppSettings
    {
        private static readonly string sr_AppUserDbFile = "./FbAppUsersDB.json";

        public List<UserSerializationData> UsersSerializationData { get; set; }

        private AppSettings()
        {
            this.ReloadUsersList();
        }

        public static AppSettings Instance 
        { 
            get
            {
                return Singleton<AppSettings>.Instance;
            }
        }

        public void SaveUsersToDB()
        {
            string jsonFormatUser = JsonSerializer.Serialize(this.UsersSerializationData);
            File.WriteAllText(sr_AppUserDbFile, jsonFormatUser);
        }

        public void ReloadUsersList()
        {
            if (File.Exists(sr_AppUserDbFile))
            {
                string fileContent = File.ReadAllText(sr_AppUserDbFile);
                if (!string.IsNullOrEmpty(fileContent))
                {
                    this.UsersSerializationData = JsonSerializer.Deserialize<List<UserSerializationData>>(fileContent);
                }
                else
                {
                    this.UsersSerializationData = new List<UserSerializationData>();
                }
            }
            else
            {
                File.Create(sr_AppUserDbFile);
                this.UsersSerializationData = new List<UserSerializationData>();
            }
        }

        public bool isUserNameAlreadyInDB(string i_UserName)
        {
            bool result = false;
            foreach (UserSerializationData userSerialization in this.UsersSerializationData)
            {
                if (userSerialization.UserName == i_UserName)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public void updateUserAccessToken(string i_UserName, string i_AccessToken)
        {
            foreach (UserSerializationData userSerialization in this.UsersSerializationData)
            {
                if (userSerialization.UserName == i_UserName)
                {
                    userSerialization.AccessToken = i_AccessToken;
                    break;
                }
            }
        }
    }
}
