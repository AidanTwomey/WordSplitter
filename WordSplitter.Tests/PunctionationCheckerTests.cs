using NUnit.Framework;

namespace WordSplitter.Tests
{
    [TestFixture]
    public class PunctionationCheckerTests
    {
        
        [Test]
        public void RemovePunctuation_FullStop()
        {
            const string word = "word.";

            const string expected = "word";
            
            Assert.AreEqual(expected, PunctuationChecker.RemovePunctuation(word) );
        }

        [Test]
        public void RemovePunctuation_Comma()
        {
            const string word = "word,";

            const string expected = "word";

            Assert.AreEqual(expected, PunctuationChecker.RemovePunctuation(word));
        }


        [Test]
        public void RemovePunctuation_ExtraSpaces()
        {
            const string word = "word, ";

            const string expected = "word";

            Assert.AreEqual(expected, PunctuationChecker.RemovePunctuation(word));
        }
    }
}