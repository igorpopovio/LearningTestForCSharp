using System.Collections.Generic;
using NUnit.Framework;

namespace LearningTestForCSharp.Collections
{
    [TestFixture]
    public class DictionaryTests
    {
        [Test]
        public void ContainsKeyValuePair()
        {
            Assert.That(CreateTestDictionary(),
                Has.Member(new KeyValuePair<string, int>("aaa", 1)));
        }

        [Test]
        public void IterationWithKeyValuePair()
        {
            var dictionary = CreateTestDictionary();
            foreach (KeyValuePair<string, int> pair in dictionary)
                Assert.That(pair.Key, Has.Length.EqualTo(3));
        }

        [Test]
        public void IterationWithVar()
        {
            var dictionary = CreateTestDictionary();
            foreach (var pair in dictionary)
                Assert.That(pair.Key, Has.Length.EqualTo(3));
        }

        [Test]
        public void AddingNewPairs()
        {
            var languageIde = new Dictionary<string, string>();
            languageIde.Add("Java", "IntelliJ IDEA");
            languageIde.Add("C#", "Visual Studio");
            Assert.That(languageIde, Has.Count.EqualTo(2));
            Assert.That(languageIde.Keys, Is.EquivalentTo(new[] { "Java", "C#" }));
        }

        [Test]
        public void AccessingKeys()
        {
            var dictionary = CreateTestDictionary();
            Assert.That(dictionary["aaa"], Is.EqualTo(1));
        }

        public Dictionary<string, int> CreateTestDictionary()
        {
            return new Dictionary<string, int>
            {
                {"aaa", 1},
                {"bbb", 2},
                {"ccc", 3}
            };
        }
    }
}
