using System;
using System.Text.RegularExpressions;

namespace Textor.Calculators
{
    public class WordsCalculator : ICalculator
    {
        public uint Count(string text)
        {
            var matches = Regex.Matches(text, $"[a-zA-Zàéèçùêô@]+");
            return (uint)matches.Count;
        }
    }
}