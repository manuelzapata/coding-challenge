using CodingChallenge.Library.StacksQueues;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Tests.StacksQueues
{
    [TestClass]
    public class FishTests
    {

        [TestMethod]
        public void FishSolutionTest()
        {
            var fish = new Fish();

            int[] sizes = { 4, 3, 2, 1, 5 };
            int[] directions = { 0, 1, 0, 0, 0 };
            int result = fish.Solve(sizes, directions);
            Assert.AreEqual(2, result);

            //All fish in the same direction.
            sizes = new int[] { 4, 3, 2, 1, 5 };
            directions = new int[5];
            result = fish.Solve(sizes, directions);
            Assert.AreEqual(5, result);

            //one fish
            sizes = new int[] { 4 };
            directions = new int[1];
            result = fish.Solve(sizes, directions);
            Assert.AreEqual(1, result);

            //two fish
            sizes = new int[] { 4, 3 };
            directions = new int[] { 0, 1 };
            result = fish.Solve(sizes, directions);
            Assert.AreEqual(2, result);

            sizes = new int[] { 4, 3 };
            directions = new int[] {  1 , 0 };
            result = fish.Solve(sizes, directions);
            Assert.AreEqual(1, result);

            sizes = new int[] { 3, 4 };
            directions = new int[] { 1, 0 };
            result = fish.Solve(sizes, directions);
            Assert.AreEqual(1, result);

            sizes = new int[] { 1, 2 };
            directions = new int[] { 0, 1 };
            result = fish.Solve(sizes, directions);
            Assert.AreEqual(2, result);

            //all except one fish flowing in the same direction
            sizes = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            directions = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            result = fish.Solve(sizes, directions);
            Assert.AreEqual(1, result);
        }

    }
}
