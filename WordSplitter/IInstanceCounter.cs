using System.Collections.Generic;

namespace WordSplitter
{
    public interface IInstanceCounter
    {
        Dictionary<string, int> Count(string sentence);
    }
}