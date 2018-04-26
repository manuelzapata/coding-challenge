using CodingChallenge.Library.Leader;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Tests.Leader
{
    [TestClass]
    public class EquiLeaderTests
    {

        [TestMethod]
        public void EquiLeaderSolutionTest()
        {
            var equiLeader = new EquiLeader();

            int[] array = { 4, 3, 4, 4, 4, 2 };

            int result = equiLeader.Solve(array);
            Assert.AreEqual(2, result);
        }

    }
}
