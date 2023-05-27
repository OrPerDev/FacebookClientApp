using System;
using System.Collections;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class FacebookUserFilter : IEnumerable<User>
    {
        private readonly FacebookObjectCollection<User> r_FacebookUsers;
        public readonly Func<User, bool> R_UserFilter;

        public FacebookUserFilter(Func<User, bool> i_UserFilter, FacebookObjectCollection<User> i_FacebookUsers)
        {
            this.r_FacebookUsers = i_FacebookUsers;
            if (i_UserFilter == null)
            {
                this.R_UserFilter = (User user) => true;
            }
            else
            {
                this.R_UserFilter = i_UserFilter;
            }
        }

        public IEnumerator<User> GetEnumerator()
        {
            foreach (User user in this.r_FacebookUsers)
            {
                if (this.R_UserFilter.Invoke(user))
                {
                    yield return user;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
