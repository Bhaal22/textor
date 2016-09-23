using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Textor.SortStrategies;

namespace UT_TextorService
{
    [TestClass]
    public class IgnoreCaseSortTests
    {
        [TestMethod]
        public void WordsWithSameLatinlettersSortedTheSameWay()
        {
            var paragraph = "upperCaSe UppERcASE upperCaSE";
            var sorter = new IgnoreCaseSorter();

            var sorted = sorter.Sort(paragraph);
            Assert.AreEqual(paragraph, sorted);
        }

        [TestMethod]
        public void ThreeSentencesWithDifferentcases()
        {
            var paragraph = "upperCaSe. UppERcASE .upperCaSE";
            var sorter = new IgnoreCaseSorter();

            var sorted = sorter.Sort(paragraph);
            Assert.AreEqual("upperCaSe UppERcASE upperCaSE", sorted);
        }
    }
}
