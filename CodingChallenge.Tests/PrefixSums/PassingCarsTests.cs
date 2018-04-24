using CodingChallenge.Library.PrefixSums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Tests.PrefixSums
{
    [TestClass]
    public class PassingCarsTests
    {

        [TestMethod]
        public void PassingCarsSolutionTest()
        {
            var passingCars = new PassingCars();

            int[] array = { 0, 1, 0, 1, 1 };
            int result = passingCars.Solve(array);
            Assert.AreEqual(5, result);
        }

    }
}
