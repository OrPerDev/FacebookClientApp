using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public sealed class HighestFriendScoreBuilder : IFriendScoreBuilder
    {
        private IFriendScore m_FriendScore = new MutualsFriendScore();

        public HighestFriendScoreBuilder()
        {
        }

        public KeyValuePair<IFriendScore, User> GetFriendScoreAndFriend(User io_CurrentUser, Func<User, bool> i_FriendsFilter)
        {
            if (io_CurrentUser == null)
            {
                throw new Exception("No User is set to check for friends.");
            }

            IFriendScore highestFriendScore = new MutualsFriendScore();
            User highestScoreFriend = null;
            FacebookUserFilter filteredFriends = new FacebookUserFilter(i_FriendsFilter, io_CurrentUser.Friends);
            IEnumerator<User> filteredFriendsIterator = filteredFriends.GetEnumerator();
            using (filteredFriendsIterator)
            {
                while (filteredFriendsIterator.MoveNext())
                {
                    this.m_FriendScore.ResetScore();
                    if (highestFriendScore.Score < fetchIndividualFriendScore(io_CurrentUser, filteredFriendsIterator.Current))
                    {
                        highestFriendScore = this.m_FriendScore;
                        highestScoreFriend = filteredFriendsIterator.Current;
                    }
                }
            }

            return new KeyValuePair<IFriendScore, User>(highestFriendScore, highestScoreFriend);
        }

        private int fetchIndividualFriendScore(User io_CurrentUser, User io_CurrentFriend)
        {
            Thread fetchPostsScoreThread = new Thread(() => fetchFriendsLikesCommentsTagsFromPosts((MutualsFriendScore)this.m_FriendScore, io_CurrentUser, io_CurrentFriend.Name));
            fetchPostsScoreThread.Start();
            Thread fetchMutualFriendsScoreThread = new Thread(() => fetchMutualFriendsWithFriend((MutualsFriendScore)this.m_FriendScore, io_CurrentUser, io_CurrentFriend));
            fetchMutualFriendsScoreThread.Start();
            Thread fetchMutualGroupsScoreThread = new Thread(() => fetchMutualGroupsWithFriend((MutualsFriendScore)this.m_FriendScore, io_CurrentUser, io_CurrentFriend));
            fetchMutualGroupsScoreThread.Start();
            Thread fetchTaggingScoreThread = new Thread(() => fetchFriendTaggingScore((MutualsFriendScore)this.m_FriendScore, io_CurrentUser, io_CurrentFriend.Name));
            fetchTaggingScoreThread.Start();
            fetchPostsScoreThread.Join();
            fetchMutualFriendsScoreThread.Join();
            fetchMutualGroupsScoreThread.Join();
            fetchTaggingScoreThread.Join();
            return this.m_FriendScore.Score;
        }

        private void fetchFriendsLikesCommentsTagsFromPosts(MutualsFriendScore i_CurrentFriendScore, User i_CurrentUser, string i_CurrentFriendName)
        {
            try
            {
                i_CurrentFriendScore.Comments += i_CurrentUser.Posts.Count(post => post.Comments != null && post.Comments.Any(comment => comment.From.Name.Contains(i_CurrentFriendName)));
            }
            catch (Exception)
            {
                goto Likes;
            }

        Likes:
            try
            {
                i_CurrentFriendScore.Likes += i_CurrentUser.Posts.Count(post => post.LikedBy.Any(userLiked => userLiked.Name == i_CurrentFriendName));
            }
            catch (Exception)
            {
                goto Tags;
            }

        Tags:
            try
            {
                i_CurrentFriendScore.Tags += i_CurrentUser.Posts.Count(post => !string.IsNullOrEmpty(post.Message) && post.Message.Contains(i_CurrentFriendName));
            }
            catch (Exception)
            {
                return;
            }
        }

        private void fetchFriendTaggingScore(MutualsFriendScore i_CurrentFriendScore, User i_CurrentUser, string i_CurrentFriendName)
        {
            try
            {
                i_CurrentFriendScore.Tags += i_CurrentUser.PhotosTaggedIn.Count(photo => photo.Tags.Any(tag => tag.User.Name == i_CurrentFriendName));
            }
            catch (Exception)
            {
                return;
            }
        }

        private void fetchMutualFriendsWithFriend(MutualsFriendScore i_CurrentFriendScore, User i_CurrentUser, User i_CurrentFriend)
        {
            try
            {
                List<string> currentUserFriends = i_CurrentUser.Friends.Select(friend => friend.Name).ToList();
                List<string> friendFriends = i_CurrentFriend.Friends.Select(friend => friend.Name).ToList();
                i_CurrentFriendScore.MutualFriends = currentUserFriends.Count(friendName => friendFriends.Contains(friendName));
            }
            catch (Exception)
            {
                return;
            }
        }

        private void fetchMutualGroupsWithFriend(MutualsFriendScore i_CurrentFriendScore, User i_CurrentUser, User i_CurrentFriend)
        {
            try
            {
                List<string> currentUserGroups = i_CurrentUser.Groups.Select(group => group.Name).ToList();
                List<string> friendGroups = i_CurrentFriend.Groups.Select(group => group.Name).ToList();
                i_CurrentFriendScore.MutualGroups = currentUserGroups.Count(groupName => friendGroups.Contains(groupName));
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
