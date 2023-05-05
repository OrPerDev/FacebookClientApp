using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class FriendScoreComposer
    {
        private readonly User r_CurrentUser;
        private readonly FriendScoreManager r_FriendScoreManager = FriendScoreManager.Instance;

        public FriendScoreComposer(User i_CurrentUser)
        {
            this.r_CurrentUser = i_CurrentUser;
        }

        public KeyValuePair<FriendScore, User> ComposeFriendScoreResult()
        {
            return this.r_FriendScoreManager.GetHighestScoreFriend(this.r_CurrentUser);
        }
    }
}
