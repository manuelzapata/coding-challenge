using CodingChallenge.Library.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Tests.Sorting
{

    [TestClass]
    public class NumberOfDiscIntersectionsTests
    {

        [TestMethod]
        public void NumberOfDiscIntersectionsSolutionTest()
        {
            var discs = new NumberOfDiscIntersections();

            int[] array = { 1, 5, 2, 1, 4, 0 };
            int result = discs.Solve(array);
            Assert.AreEqual(11, result);
        }

    }
}
