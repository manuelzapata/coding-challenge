using CodingChallenge.Library.Leader;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Tests.Leader
{
    [TestClass]
    public class DominatorTests
    {

        [TestMethod]
        public void DominatorSolutionTest()
        {
            var dominator = new Dominator();

            int[] array = { 3, 4, 3, 2, 3, -1, 3, 3 };
            int result = dominator.Solve(array);
            Assert.IsTrue(result == 0 || result == 2 || result == 4 || result == 6 || result == 7);

            //No dominator
            array = new int[] { 1, 2, 3 };
            result = dominator.Solve(array);
            Assert.AreEqual(-1, result);

            //Array of size 1
            array = new int[] { 1 };
            result = dominator.Solve(array);
            Assert.AreEqual(0, result);

            array = new int[0];
            result = dominator.Solve(array);
            Assert.AreEqual(-1, result);

        }

    }
}
