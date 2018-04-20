using CodingChallenge.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Tests
{
    [TestClass]
    public class CyclicRotationTests
    {

        [TestMethod]
        public void CyclicRotationSolutionTest() {

            var cyclicRotation = new CyclicRotation();

            int[] array = new int[] { 3, 8, 9, 7, 6 };
            int k = 3;

            int[] result = cyclicRotation.Solve(array, k);
            int[] expected = new int[] { 9, 7, 6, 3, 8 };
            CollectionAssert.AreEqual(expected, result);

            array = new int[] {0, 0, 0};
            k = 1;
            result = cyclicRotation.Solve(array, k);
            expected = new int[] { 0, 0, 0 };
            CollectionAssert.AreEqual(expected, result);

            array = new int[] { 1, 2, 3, 4 };
            k = 4;
            result = cyclicRotation.Solve(array, k);
            expected = new int[] { 1, 2, 3, 4 };
            CollectionAssert.AreEqual(expected, result);


        }

    }
}
