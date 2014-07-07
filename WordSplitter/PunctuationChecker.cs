using System.Collections.Generic;
using System.Linq;

namespace WordSplitter
{
    public class PunctuationChecker
    {
        private static readonly HashSet<char> _punctuationMarks = new HashSet<char>() { '.', ',' };

        public static string RemovePunctuation(string word)
        {
            word = word.Trim();
            return _punctuationMarks.Contains(word.Last()) ? word.Substring(0, word.Length - 1) : word;
        }
    }
}