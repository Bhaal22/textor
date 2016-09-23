using System;

namespace Textor
{
    public class Textor : ITextor
    {
        public string Sort(string text, SortOption sortOption)
        {
            throw new NotImplementedException();
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
