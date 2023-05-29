using System;
using System.Collections.Generic;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppClient
{
    public class FriendScoreCreator
    {
        private readonly IFriendScoreBuilder r_FriendScoreBuilder;
        private readonly User r_CurrentUser;
        private readonly Func<User, bool> r_FriendsFilter;

        public FriendScoreCreator(IFriendScoreBuilder i_FriendScoreBuilder, User i_CurrentUser, Func<User, bool> i_FriendsFilter = null)
        {
            this.r_FriendScoreBuilder = i_FriendScoreBuilder;
            this.r_CurrentUser = i_CurrentUser;
            this.r_FriendsFilter = i_FriendsFilter;
        }

        public KeyValuePair<IFriendScore, User> ComposeFriendScoreResult()
        {
            return this.r_FriendScoreBuilder.GetFriendScoreAndFriend(this.r_CurrentUser, this.r_FriendsFilter);
        }
    }
}
