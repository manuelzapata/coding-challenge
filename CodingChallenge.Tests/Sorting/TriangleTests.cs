using CodingChallenge.Library.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Tests.Sorting
{
    [TestClass]
    public class TriangleTests
    {

        [TestMethod]
        public void TriangleSolutionTest()
        {
            var triangle = new Triangle();

            int[] array = { 10, 2, 5, 1, 8, 20 };
            int result = triangle.Solve(array);
            Assert.AreEqual(1, result);

            array = new int[] { 10, 50, 5, 1, };

            result = triangle.Solve(array);
            Assert.AreEqual(0, result);
        }

    }
}
