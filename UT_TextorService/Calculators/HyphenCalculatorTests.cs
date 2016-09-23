using Microsoft.VisualStudio.TestTools.UnitTesting;
using Textor.Calculators;

namespace UT_TextorService.Calculators
{
    [TestClass]
    public class HyphenCalculatorTests
    {
        [TestMethod]
        public void CountHyphensWhenThereAreOnlySpaces()
        {
            var sentence = "my sentence    is only           spaces";

            var calculator = new HyphensCalculator();
            var countHyphens = calculator.Count(sentence);

            Assert.AreEqual((uint)4, countHyphens);
        }
    }
}
