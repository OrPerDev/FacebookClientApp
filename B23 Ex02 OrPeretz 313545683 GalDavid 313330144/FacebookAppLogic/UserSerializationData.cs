using System;
using System.Text.Json.Serialization;

namespace FacebookAppLogic
{
    public class UserSerializationData
    {
        [JsonPropertyName("AccessToken")]
        public string AccessToken { get; set; }

        [JsonPropertyName("UserName")]
        public string UserName { get; set; }

        [JsonPropertyName("TokenCreationTime")]
        public DateTime TokenCreationTime { get; set; }

        public UserSerializationData(string i_AccessToken, string i_UserName, DateTime i_TokenCreationTime)
        {
            this.AccessToken = i_AccessToken;
            this.UserName = i_UserName;
            this.TokenCreationTime = i_TokenCreationTime;
        }

        [JsonConstructor]
        public UserSerializationData()
        {
        }
    }
}
