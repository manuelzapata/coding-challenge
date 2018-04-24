using CodingChallenge.Library.PrefixSums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Tests.PrefixSums
{
    [TestClass]
    public class CountDivTests
    {

        [TestMethod]
        public void CountDivSolutionTest()
        {
            var countDiv = new CountDiv();

            int result = countDiv.Solve(6, 11, 2);
            Assert.AreEqual(3, result);

            result = countDiv.Solve(7, 11, 2);
            Assert.AreEqual(2, result);

            result = countDiv.Solve(7, 11, 3);
            Assert.AreEqual(1, result);

            result = countDiv.Solve(98, 100, 3);
            Assert.AreEqual(1, result);

            result = countDiv.Solve(10, 20, 15);
            Assert.AreEqual(1, result);

            result = countDiv.Solve(0, 1, 1);
            Assert.AreEqual(2, result);

            result = countDiv.Solve(0, 2000000000, 1);
            Assert.AreEqual(2000000001, result);
        }

    }
}
