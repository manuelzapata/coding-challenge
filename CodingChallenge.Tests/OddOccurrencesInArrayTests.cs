using CodingChallenge.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Tests
{
    [TestClass]
    public class OddOccurrencesInArrayTests
    {

        [TestMethod]
        public void OddOccurrencesInArrayTest()
        {

            var odd = new OddOccurrencesInArray();

            int[] array = new int[] { 9, 3, 9, 3, 9, 7, 9 };


            int result = odd.Solve(array);
            Assert.AreEqual(7, result);
        }

    }
}
