using System;
using Textor.SortStrategies;

namespace Textor
{
    public class Textor : ITextor
    {
        public string Sort(string text, SortOption sortOption)
        {
            ISortStrategy strategy;
            switch (sortOption)
            {
                case SortOption.IgnoreCase:
                    strategy = new IgnoreCaseSorter();
                    break;
                default:
                    throw new NotSupportedException($"Specified sort option {sortOption} not supported");
            }

            return strategy.Sort(text);
        }

        public TextStatistics Statistics(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException("composite");
            }


            return new TextStatistics();
        }
    }
}
