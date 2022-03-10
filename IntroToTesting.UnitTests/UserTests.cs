using NUnit.Framework;
using System.Collections.Generic;

namespace IntroToTesting.UnitTests
{
    public class UserTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Constructor_WhenInstantiated_SetsStartingPropertyValues()
        {
            var user = new User("Archie");

            Assert.That(user.Name, Is.EqualTo("Archie"));
            Assert.That(user.Tweets, Is.EqualTo(new List<string>()));
        }

        [Test]
        public void Username_WhenAssigned_IsSetAsProperty()
        {
            var user = new User("Archie");

            user.UserName = "@ArchieTheAwesome";

            Assert.That(user.UserName, Is.EqualTo("@ArchieTheAwesome"));
        }

        [Test]
        public void Tweet_WhenCalled_AddsMessageToTweets()
        {
            var user = new User("Archie");

            user.Tweet("abc");
            user.Tweet("def");
            
            // A good way to assert that this method is working:
            Assert.That(user.Tweets.Count, Is.EqualTo(2));
            Assert.That(user.Tweets[0], Is.EqualTo("abc"));
            Assert.That(user.Tweets[1], Is.EqualTo("def"));

            // Another good way to assert that this method is working:
            Assert.That(user.Tweets, Is.EqualTo(new List<string> { "abc", "def" }));
        }

        [Test]
        public void MostRecentTweet_WhenCalled_ReturnsLastTweet()
        {
            var user = new User("Archie");

            user.Tweet("abc");
            user.Tweet("def");
            user.Tweet("ghi");

            Assert.That(user.MostRecentTweet(), Is.EqualTo("ghi"));
        }
    }
}