using System;
using System.Text.RegularExpressions;
using Textor.SortStrategies;

namespace Textor.Calculators
{
    public class HyphensCalculator : ICalculator
    {
        public uint Count(string text)
        {
            var matches = Regex.Matches(text, $"[{string.Join("", Separator.Hyphens)}]+");
            return (uint)matches.Count;
        }
    }
}