using Microsoft.VisualStudio.TestTools.UnitTesting;
using Textor.Calculators;

namespace UT_TextorService.Calculators
{
    [TestClass]
    public class WordsCalculatorTests
    {
        [TestMethod]
        public void NonEnglishWordsMustBeCount()
        {
            var sentence = "je fais du vélo dans la fôret."; //I do bike in the forest in French

            var calculator = new WordsCalculator();
            var countWords = calculator.Count(sentence);

            Assert.AreEqual((uint)7, countWords);
        }
    }
}
