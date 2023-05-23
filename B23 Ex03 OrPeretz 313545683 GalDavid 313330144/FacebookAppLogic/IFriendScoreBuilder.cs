using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public interface IFriendScoreBuilder
    {
        KeyValuePair<IFriendScore, User> GetFriendScoreAndFriend(User io_CurrentUser, Func<User,bool> i_FriendsFilter);
    }
}