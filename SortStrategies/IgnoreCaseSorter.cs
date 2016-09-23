using System;

namespace Textor.SortStrategies
{
    public class IgnoreCaseSorter : ISortStrategy
    {
        public string Sort(string text)
        {
            var words = text.Split(new char[] { ' ' });

            Array.Sort(words, StringComparer.InvariantCultureIgnoreCase);
            return string.Join(" ", words);
        }
    }
}