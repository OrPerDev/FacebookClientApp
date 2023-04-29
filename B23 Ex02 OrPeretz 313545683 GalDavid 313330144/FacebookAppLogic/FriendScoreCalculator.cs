using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public static class FriendScoreCalculator
    {
        public static KeyValuePair<int, User> GetHighestScoreFriend(User io_CurrentUser)
        {
            User highestScoreFriend = null;
            int currentHighestScore = -1;
            Dictionary<int, User> friendsAndScores = fetchFriendsScores(io_CurrentUser);
            foreach (KeyValuePair<int, User> userAndScore in friendsAndScores)
            {
                if (currentHighestScore < userAndScore.Key)
                {
                    highestScoreFriend = userAndScore.Value;
                    currentHighestScore = userAndScore.Key;
                }
            }

            return new KeyValuePair<int, User>(currentHighestScore, highestScoreFriend);
        }

        private static Dictionary<int, User> fetchFriendsScores(User io_CurrentUser)
        {
            Dictionary<int, User> friendsScores = new Dictionary<int, User>();
            FriendScore currentFriendScore = new FriendScore();
            foreach (User friend in io_CurrentUser.Friends)
            {
                try
                {
                    currentFriendScore.ResetScore();
                    fetchFriendsLikesCommentsTagsFromPosts(currentFriendScore, io_CurrentUser, friend.Name);
                    fetchMutualFriendsWithFriend(currentFriendScore, io_CurrentUser, friend);
                    fetchMutualGroupsWithFriend(currentFriendScore, io_CurrentUser, friend);
                    fetchFriendTaggingScore(currentFriendScore, io_CurrentUser, friend.Name);
                    friendsScores.Add(currentFriendScore.Score, friend);
                }
                catch (Exception)
                {
                    friendsScores.Add(currentFriendScore.Score, friend);
                    continue;
                }
            }

            return friendsScores;
        }

        private static void fetchFriendsLikesCommentsTagsFromPosts(FriendScore i_CurrentFriendScore, User i_CurrentUser, string i_CurrentFriendName)
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

        private static void fetchFriendTaggingScore(FriendScore i_CurrentFriendScore, User i_CurrentUser, string i_CurrentFriendName)
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

        private static void fetchMutualFriendsWithFriend(FriendScore i_CurrentFriendScore, User i_CurrentUser, User i_CurrentFriend)
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

        private static void fetchMutualGroupsWithFriend(FriendScore i_CurrentFriendScore, User i_CurrentUser, User i_CurrentFriend)
        {
            List<string> currentUserGroups = i_CurrentUser.Groups.Select(group => group.Name).ToList();
            List<string> friendGroups = i_CurrentFriend.Groups.Select(group => group.Name).ToList();
            i_CurrentFriendScore.MutualGroups = currentUserGroups.Where(groupName => friendGroups.Contains(groupName)).ToList().Count();
        }
    }
}
