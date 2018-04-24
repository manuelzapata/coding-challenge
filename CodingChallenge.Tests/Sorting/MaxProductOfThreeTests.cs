using CodingChallenge.Library.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Tests.Sorting
{
    [TestClass]
    public class MaxProductOfThreeTests
    {

        [TestMethod]
        public void MaxProductOfThreeSolutionTest()
        {
            var product = new MaxProductOfThree();

            int[] array = new int[] { -3, 1, 2, -2, 5, 6 };
            int result = product.Solve(array);
            Assert.AreEqual(60, result);

            array = new int[] { -3000, -10, 2, 5, 10  };
            result = product.Solve(array);
            Assert.AreEqual(300000, result);

            array = new int[] { -10, -2, -4 };
            result = product.Solve(array);
            Assert.AreEqual(-80, result);

            array = new int[] { -5, -5, 4, 5 };
            result = product.Solve(array);
            Assert.AreEqual(125, result);

        }

    }
}
