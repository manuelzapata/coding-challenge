using CodingChallenge.Library.PrefixSums2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Tests.PrefixSums2
{
    [TestClass]
    public class MinAvgTwoSliceTests
    {

        [TestMethod]
        public void MinAvgTwoSliceSolutionTest()
        {
            var sliceAverage = new MinAvgTwoSlice();
            int[] array = { 4, 2, 2, 5, 1, 5, 8 };

            int result = sliceAverage.Solve(array);
            Assert.AreEqual(1, result);
        }

    }
}
