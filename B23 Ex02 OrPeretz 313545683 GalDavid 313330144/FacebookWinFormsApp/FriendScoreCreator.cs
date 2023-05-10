using System.Collections.Generic;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppClient
{
    public class FriendScoreCreator
    {
        private readonly IFriendScoreBuilder r_FriendScoreBuilder;
        private readonly User r_CurrentUser;

        public FriendScoreCreator(IFriendScoreBuilder i_FriendScoreBuilder, User i_CurrentUser)
        {
            this.r_FriendScoreBuilder = i_FriendScoreBuilder;
            this.r_CurrentUser = i_CurrentUser;
        }

        public KeyValuePair<IFriendScore, User> ComposeFriendScoreResult()
        {
            return this.r_FriendScoreBuilder.GetFriendScoreAndFriend(this.r_CurrentUser);
        }
    }
}
