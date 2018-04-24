using CodingChallenge.Library.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Tests.Sorting
{

    [TestClass]
    public class DistinctTests
    {

        [TestMethod]
        public void DistinctSolutionTest()
        {
            var distinct = new Distinct();

            int[] array = { 2, 1, 1, 2, 3, 1 };
            int result = distinct.Solve(array);

            Assert.AreEqual(3, result);
        }

    }
}
