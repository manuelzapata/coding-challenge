using CodingChallenge.Library.StacksQueues;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Tests.StacksQueues
{
    [TestClass]
    public class StoneWallTests
    {

        [TestMethod]
        public void StoneWallSolutionTest()
        {

            var stoneWall = new StoneWall();

            int[] array = { 8, 8, 5, 7, 9, 8, 7, 4, 8 };
            int result = stoneWall.Solve(array);
            Assert.AreEqual(7, result);

            array = new int[] { 2, 3, 2, 1 };
            result = stoneWall.Solve(array);
            Assert.AreEqual(3, result);

        }

    }
}
