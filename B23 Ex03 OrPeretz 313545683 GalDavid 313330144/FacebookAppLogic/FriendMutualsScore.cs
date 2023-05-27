namespace FacebookAppLogic
{
    public class FriendMutualsScore : IFriendScore
    {
        public int Tags { get; set; } = 0;

        public int Likes { get; set; } = 0;

        public int Comments { get; set; } = 0;

        public int MutualFriends { get; set; } = 0;

        public int MutualGroups { get; set; } = 0;

        public FriendMutualsScore()
        {
        }

        public int Score
        {
            get
            {
                return this.Tags + this.Likes + this.MutualFriends + this.Comments + this.MutualGroups;
            }
        }

        public void ResetScore()
        {
            this.Tags = this.Likes = this.Comments = this.MutualFriends = this.MutualGroups = 0;
        }
    }
}
