using System;
using Textor.Calculators;
using Textor.SortStrategies;

namespace Textor
{
    public class Textor : ITextor
    {
        public string Sort(string text, SortOption sortOption)
        {
            if (text == null)
                throw new ArgumentNullException("Input text is null.");
            
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
                throw new ArgumentNullException("Input text is null.");

            var hyphensCalculator = new HyphensCalculator();
            var wordsCalculator = new WordsCalculator();
            var spacesCalculator = new SpacesCalculator();


            return new TextStatistics()
            {
                HyphensCount = hyphensCalculator.Count(text),
                SpacesCount = spacesCalculator.Count(text),
                WordsCount = wordsCalculator.Count(text)
            };
        }
    }
}
