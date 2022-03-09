namespace IntroToTesting
{
    public class User
    {
        public string Name { get; }
        public string UserName { get; set; }
        public List<string> Tweets { get; }

        public User(string name)
        {
            Name = name;
            Tweets = new List<string>();
        }

        public void Tweet(string message)
        {
            Tweets.Add(message);
        }

        public string MostRecentTweet()
        {
            var lastIndex = Tweets.Count - 1;
            return Tweets[lastIndex];
        }
    }
}
