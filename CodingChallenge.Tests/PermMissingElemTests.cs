using CodingChallenge.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Tests
{
    [TestClass]
    public class PermMissingElemTests
    {

        [TestMethod]
        public void PermMissingElemSolutionTest() {
            var missingElement = new PermMissingElem();

            //N = 4
            int[] array = new int[] { 2, 3, 1, 5 };
            int result = missingElement.Solve(array);
            Assert.AreEqual(4, result);

            //N = 1
            array = new int[] { 2 };
            result = missingElement.Solve(array);
            Assert.AreEqual(1, result);

        }

    }
}
