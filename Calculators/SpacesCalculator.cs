using System;
using System.Text.RegularExpressions;

namespace Textor.Calculators
{
    public class SpacesCalculator : ICalculator
    {
        public uint Count(string text)
        {
            var matches = Regex.Matches(text.Trim(), @"\s+");
            return (uint)matches.Count;
        }
    }
}