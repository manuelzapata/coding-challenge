using CodingChallenge.Library.Counting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Tests.Counting
{
    [TestClass]
    public class MissingIntegerTests
    {

        [TestMethod]
        public void MissingIntegerSolutionTest()
        {
            var missingInteger = new MissingInteger();

            int[] array = new int[] { 1, 3, 6, 4, 1, 2 };
            int result = missingInteger.Solve(array);
            Assert.AreEqual(5, result);

            array = new int[] { 1, 2, 3 };
            result = missingInteger.Solve(array);
            Assert.AreEqual(4, result);

            array = new int[] { -1, -3 };
            result = missingInteger.Solve(array);
            Assert.AreEqual(1, result);

            array = new int[] { -1000000, 1000000 };
            result = missingInteger.Solve(array);
            Assert.AreEqual(1, result);
        }

    }
}
