using System.Collections.Generic;
using NUnit.Framework;

namespace WordSplitter.Tests
{
    [TestFixture]
    public class InstanceCounterTests
    {
        [Test]
        public void InstanceCounter_SplitSentence()
        {
            const string sentence = "This is a statement. and so is this";

            var instanceCounter = new InstanceCounter();

            Dictionary<string, int> result = instanceCounter.Count(sentence);

            var expected = new Dictionary<string, int>()
            {
                {"this", 2},
                {"is", 2},
                {"a", 1},
                {"statement", 1},
                {"and", 1},
                {"so", 1},
            };

            CollectionAssert.AreEqual( expected, result );
        }


        [Test]
        public void InstanceCounter_SplitSentence_CaseInsensitive()
        {
            const string sentence = "This THIS this tHiS This";

            var instanceCounter = new InstanceCounter();

            Dictionary<string, int> result = instanceCounter.Count(sentence);

            var expected = new Dictionary<string, int>()
            {
                {"this", 5}
            };

            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void InstanceCounter_NullCheck()
        {
            
            var instanceCounter = new InstanceCounter();

            Dictionary<string, int> result = instanceCounter.Count(null);

            var expected = new Dictionary<string, int>();

            CollectionAssert.AreEqual(expected, result);
        }


        [Test]
        public void InstanceCounter_EmptyCheck()
        {
            const string sentence = "  ";

            var instanceCounter = new InstanceCounter();

            Dictionary<string, int> result = instanceCounter.Count(sentence);

            var expected = new Dictionary<string, int>();

            CollectionAssert.AreEqual(expected, result);
        }
    }
}

