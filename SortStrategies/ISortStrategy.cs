using System.Collections.Generic;

namespace Textor.SortStrategies
{
    public class Separator
    {
        public static List<char> Hyphens { get; } = new List<char>() { ' ', ',', '.' };
    }

    public interface ISortStrategy
    { 
        string Sort(string text);
    }
}
