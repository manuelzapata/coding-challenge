using CodingChallenge.Library.PrefixSums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Tests.PrefixSums
{

    [TestClass]
    public class GenomicRangeQueryTests
    {

        [TestMethod]
        public void GenomicRangeQuerySolutionTest()
        {

            var genomicRangeQuery = new GenomicRangeQuery();

            var sequence = "CAGCCTA";
            int[] queryOne = { 2, 5, 0 };
            int[] queryTwo = { 4, 5, 6 };

            int[] result = genomicRangeQuery.Solve(sequence, queryOne, queryTwo);
            int[] expected = { 2, 4, 1 };
            CollectionAssert.AreEqual(expected, result);

        }

    }
}
