using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public sealed class HighestFriendScoreBuilder : IFriendScoreBuilder
    {
        private IFriendScore m_FriendScore = new FriendMutualsScore();
        private IFriendScoreCalculator m_FriendScoreCalculator;

        public HighestFriendScoreBuilder(IFriendScoreCalculator i_FriendScoreCalculator)
        {
            this.m_FriendScoreCalculator = i_FriendScoreCalculator;
        }

        public KeyValuePair<IFriendScore, User> GetFriendScoreAndFriend(User io_CurrentUser, Func<User, bool> i_FriendsFilter)
        {
            if (io_CurrentUser == null)
            {
                throw new Exception("No User is set to check for friends.");
            }

            IFriendScore highestFriendScore = new FriendMutualsScore();
            User highestScoreFriend = null;
            FacebookUserFilter filteredFriends = new FacebookUserFilter(i_FriendsFilter, io_CurrentUser.Friends);
            IEnumerator<User> filteredFriendsIterator = filteredFriends.GetEnumerator();
            using (filteredFriendsIterator)
            {
                while (filteredFriendsIterator.MoveNext())
                {
                    this.m_FriendScore.ResetScore();
                    if (highestFriendScore.Score < this.m_FriendScoreCalculator.calculateFriendScore(io_CurrentUser, filteredFriendsIterator.Current, this.m_FriendScore))
                    {
                        highestFriendScore = this.m_FriendScore;
                        highestScoreFriend = filteredFriendsIterator.Current;
                    }
                }
            }

            return new KeyValuePair<IFriendScore, User>(highestFriendScore, highestScoreFriend);
        }
    }
}
