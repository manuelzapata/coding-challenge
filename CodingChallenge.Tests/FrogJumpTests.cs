using CodingChallenge.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Tests
{
    [TestClass]
    public class FrogJumpTests
    {

        [TestMethod]
        public void FromJumpSolutionTest()
        {
            var frog = new FrogJump();
            int result = frog.Solve(10, 85, 30);
            Assert.AreEqual(3, result);
        }

    }
}
