using CodingChallenge.Library.Counting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Tests.Counting
{
    [TestClass]
    public class PermutationCheckTests
    {

        [TestMethod]
        public void PermutationCheckSolutionTest()
        {
            var permCheck = new PermutationCheck();

            int[] array = new int[] { 4, 1, 3, 2 };
            int result = permCheck.Solve(array);
            Assert.AreEqual(1, result);

            array = new int[] { 4, 1, 3 };
            result = permCheck.Solve(array);
            Assert.AreEqual(0, result);
        }

    }
}
