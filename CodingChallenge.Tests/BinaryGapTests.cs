using CodingChallenge.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge.Tests
{
    [TestClass]
    public class BinaryGapTests
    {
        [TestMethod]
        public void BinaryGapSolutionTest()
        {

            var binaryGap = new BinaryGap();

            int result = binaryGap.Solve(9);
            Assert.AreEqual(2, result);

            result = binaryGap.Solve(529);
            Assert.AreEqual(4, result);

            result = binaryGap.Solve(20);
            Assert.AreEqual(1, result);

            result = binaryGap.Solve(15);
            Assert.AreEqual(0, result);

            result = binaryGap.Solve(1041);
            Assert.AreEqual(5, result);

        }
    }
}
