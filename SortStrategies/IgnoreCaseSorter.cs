using System;
using System.Linq;

namespace Textor.SortStrategies
{
    public class IgnoreCaseSorter : ISortStrategy
    {
        public string Sort(string text)
        {
            var words = text.Split(Separator.Hyphens.ToArray());

            var trimmed = from word in words
                          where !string.IsNullOrWhiteSpace(word)
                          select word;

            Array.Sort(trimmed.ToArray(), StringComparer.InvariantCultureIgnoreCase);
            return string.Join(" ", trimmed);
        }
    }
}