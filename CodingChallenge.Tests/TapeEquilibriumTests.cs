using CodingChallenge.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Tests
{
    [TestClass]
    public class TapeEquilibriumTests
    {

        [TestMethod]
        public void TapeEquilibriumSolutionTest()
        {
            var tape = new TapeEquilibrium();

            int[] array = new int[] { 3, 1, 2, 4, 3 };
            int result = tape.Solve(array);
            Assert.AreEqual(1, result);
        }

    }
}
