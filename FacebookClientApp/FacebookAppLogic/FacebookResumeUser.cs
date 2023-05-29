using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class FacebookResumeUser : IFacebookResumeUser
    {
        public string About { get; set; } = null;

        public List<string> Achievements { get; } = new List<string>();

        public List<string> Hobbies { get; } = new List<string>();

        public List<string> Certifications { get; } = new List<string>();

        public List<string> References { get; } = new List<string>();

        public User FacebookUser { get; }

        public FacebookResumeUser(User i_FacebookUser)
        {
            this.FacebookUser = i_FacebookUser;
        }
    }
}