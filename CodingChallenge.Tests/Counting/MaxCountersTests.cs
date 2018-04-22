using CodingChallenge.Library.Counting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Tests.Counting
{
    [TestClass]
    public class MaxCountersTests
    {

        [TestMethod]
        public void MaxCountersSolutionTest()
        {
            var maxCounters = new MaxCounters();
            int N = 5;
            int[] array = { 3, 4, 4, 6, 1, 4, 4 };

            int[] result = maxCounters.Solve(N, array);
            int[] expected = new int[] { 3, 2, 2, 4, 2 };
            CollectionAssert.AreEqual(expected, result);

            N = 5;
            array = new int[] { 6 };

            result = maxCounters.Solve(N, array);
            expected = new int[5];
            CollectionAssert.AreEqual(expected, result);
        }

    }
}
