using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class FriendHighestScoreCalculator : IFriendScoreCalculator
    {
        public FriendHighestScoreCalculator()
        {
        }

        public int calculateFriendScore(User io_CurrentUser, User io_CurrentFriend, IFriendScore io_FriendScore)
        {
            Thread fetchPostsScoreThread = new Thread(() => fetchFriendsLikesCommentsTagsFromPosts((FriendMutualsScore)io_FriendScore, io_CurrentUser, io_CurrentFriend.Name));
            fetchPostsScoreThread.Start();
            Thread fetchMutualFriendsScoreThread = new Thread(() => fetchMutualFriendsWithFriend((FriendMutualsScore)io_FriendScore, io_CurrentUser, io_CurrentFriend));
            fetchMutualFriendsScoreThread.Start();
            Thread fetchMutualGroupsScoreThread = new Thread(() => fetchMutualGroupsWithFriend((FriendMutualsScore)io_FriendScore, io_CurrentUser, io_CurrentFriend));
            fetchMutualGroupsScoreThread.Start();
            Thread fetchTaggingScoreThread = new Thread(() => fetchFriendTaggingScore((FriendMutualsScore)io_FriendScore, io_CurrentUser, io_CurrentFriend.Name));
            fetchTaggingScoreThread.Start();
            fetchPostsScoreThread.Join();
            fetchMutualFriendsScoreThread.Join();
            fetchMutualGroupsScoreThread.Join();
            fetchTaggingScoreThread.Join();
            return io_FriendScore.Score;
        }

        private void fetchFriendsLikesCommentsTagsFromPosts(FriendMutualsScore i_CurrentFriendScore, User i_CurrentUser, string i_CurrentFriendName)
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

        private void fetchFriendTaggingScore(FriendMutualsScore i_CurrentFriendScore, User i_CurrentUser, string i_CurrentFriendName)
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

        private void fetchMutualFriendsWithFriend(FriendMutualsScore i_CurrentFriendScore, User i_CurrentUser, User i_CurrentFriend)
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

        private void fetchMutualGroupsWithFriend(FriendMutualsScore i_CurrentFriendScore, User i_CurrentUser, User i_CurrentFriend)
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
