using Microsoft.VisualStudio.TestTools.UnitTesting;
using Textor.Calculators;

namespace UT_TextorService.Calculators
{
    [TestClass]
    public class WhiteSpaceCalculatorTests
    {
        [TestMethod]
        public void RegularWhiteSpaceCalculatorOnNonTrimmedSentence()
        {
            var sentence = "je fais du vélo dans       la  fôret.   Hey là.    "; //I do bike in the forest in French. Last WS should be ignored

            var calculator = new SpacesCalculator();
            var countSpaces = calculator.Count(sentence);

            Assert.AreEqual((uint)8, countSpaces);
        }
    }
}
