using CodingChallenge.Library.Counting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Tests.Counting
{
    [TestClass]
    public class FrogRiverOneTests
    {

        [TestMethod]
        public void FrogRiverOneSolutionTest()
        {
            var frog = new FrogRiverOne();

            int[] array = new int[] { 1, 3, 1, 4, 2, 3, 5, 4 };
            int result = frog.Solve(5, array);
            Assert.AreEqual(6, result);

        }

    }
}
