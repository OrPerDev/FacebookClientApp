using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public sealed class FriendScoreManager
    {
        private FriendScoreManager()
        {}

        public static FriendScoreManager Instance
        {
            get
            {
                return Singleton<FriendScoreManager>.Instance;
            }
        }

        public KeyValuePair<FriendScore, User> GetHighestScoreFriend(User io_CurrentUser)
        {
            if (io_CurrentUser == null)
            {
                throw new Exception("No User is set to check for friends.");
            }
            Dictionary<FriendScore, User> friendsAndScores = fetchFriendsScores(io_CurrentUser);
            return friendsAndScores.Aggregate((first, second) => first.Key.Score > second.Key.Score ? first : second);
        }

        private Dictionary<FriendScore, User> fetchFriendsScores(User io_CurrentUser)
        {
            Dictionary<FriendScore, User> friendsScores = new Dictionary<FriendScore, User>();

            foreach (User friend in io_CurrentUser.Friends)
            {
                KeyValuePair<FriendScore, User> friendAndScore = this.fetchIndividualFriendScore(io_CurrentUser, friend);
                friendsScores.Add(friendAndScore.Key, friendAndScore.Value);
            }

            return friendsScores;
        }

        private KeyValuePair<FriendScore, User> fetchIndividualFriendScore(User io_CurrentUser, User io_CurrentFriend)
        {
            FriendScore currentFriendScore = new FriendScore();
            KeyValuePair<FriendScore, User>? currentFriendAndScore = null;
            try
            {
                currentFriendScore.ResetScore();
                fetchFriendsLikesCommentsTagsFromPosts(currentFriendScore, io_CurrentUser, io_CurrentFriend.Name);
                fetchMutualFriendsWithFriend(currentFriendScore, io_CurrentUser, io_CurrentFriend);
                fetchMutualGroupsWithFriend(currentFriendScore, io_CurrentUser, io_CurrentFriend);
                fetchFriendTaggingScore(currentFriendScore, io_CurrentUser, io_CurrentFriend.Name);
                currentFriendAndScore = new KeyValuePair<FriendScore, User>(key: currentFriendScore, value: io_CurrentFriend);
            }
            catch (Exception)
            {
                currentFriendAndScore = new KeyValuePair<FriendScore, User>(key: currentFriendScore, value: io_CurrentFriend);
            }
            return (KeyValuePair<FriendScore, User>)currentFriendAndScore;
        }

        private void fetchFriendsLikesCommentsTagsFromPosts(FriendScore i_CurrentFriendScore, User i_CurrentUser , string i_CurrentFriendName)
        {
            try
            {
                i_CurrentFriendScore.Comments += i_CurrentUser.Posts.Select(post => post.Comments.Where(comment => comment.From.Name == i_CurrentFriendName)).ToList().Count();
            }
            catch (Exception)
            {
                goto Likes;
            }

        Likes:
            try
            {
                i_CurrentFriendScore.Likes += i_CurrentUser.Posts.Select(post => post.LikedBy.Where(userLiked => userLiked.Name == i_CurrentFriendName)).ToList().Count();
            }
            catch (Exception)
            {
                goto Tags;
            }

        Tags:
            try
            {
                // This was the Original code - Deprecated due to tagged user return value of 0
                // i_CurrentFriendScore.Tags += i_CurrentUser.Posts.Select(post => post.TaggedUsers.Where(taggedUser => taggedUser.Name == i_CurrentFriendName)).ToList().Count();
                i_CurrentFriendScore.Tags += i_CurrentUser.Posts.Where(post => !string.IsNullOrEmpty(post.Message) && post.Message.Contains(i_CurrentFriendName)).ToList().Count();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void fetchFriendTaggingScore(FriendScore i_CurrentFriendScore, User i_CurrentUser, string i_CurrentFriendName)
        {
            try
            {
                i_CurrentFriendScore.Tags += i_CurrentUser.PhotosTaggedIn.Select(photo => photo.Tags.Where(tag => tag.User.Name == i_CurrentFriendName)).ToList().Count();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void fetchMutualFriendsWithFriend(FriendScore i_CurrentFriendScore, User i_CurrentUser, User i_CurrentFriend)
        {
            try
            {
                List<string> currentUserFriends = i_CurrentUser.Friends.Select(friend => friend.Name).ToList();
                List<string> friendFriends = i_CurrentFriend.Friends.Select(friend => friend.Name).ToList();
                i_CurrentFriendScore.MutualFriends = currentUserFriends.Where(friendName => friendFriends.Contains(friendName)).ToList().Count();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void fetchMutualGroupsWithFriend(FriendScore i_CurrentFriendScore, User i_CurrentUser, User i_CurrentFriend)
        {
            List<string> currentUserGroups = i_CurrentUser.Groups.Select(group => group.Name).ToList();
            List<string> friendGroups = i_CurrentFriend.Groups.Select(group => group.Name).ToList();
            i_CurrentFriendScore.MutualGroups = currentUserGroups.Where(groupName => friendGroups.Contains(groupName)).ToList().Count();
        }
    }
}
