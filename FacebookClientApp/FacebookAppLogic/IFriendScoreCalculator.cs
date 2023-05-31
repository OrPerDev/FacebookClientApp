using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public interface IFriendScoreCalculator
    {
        int CalculateFriendScore(User io_CurrentUser, User io_CurrentFriend, IFriendScore io_FriendScore);
    }
}
