using System.Collections.Generic;
using System.Linq;

namespace WordSplitter
{
    public class InstanceCounter: IInstanceCounter
    {

        public Dictionary<string, int> Count(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
            {
                return new Dictionary<string, int>();
            }

            return sentence.Split(' ')
                .Select(w => w.ToLower())    
                .Where(w => !string.IsNullOrEmpty(w))
                .GroupBy(PunctuationChecker.RemovePunctuation)
                .ToDictionary(g => g.Key, g => g.Count());
        }

    }
}
