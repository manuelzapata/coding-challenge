using CodingChallenge.Library.StacksQueues;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Tests.StacksQueues
{
    [TestClass]
    public class NestingTests
    {

        [TestMethod]
        public void NestingSolutionTest()
        {
            var nesting = new Nesting();

            int result = nesting.Solve("((()()))");
            Assert.AreEqual(1, result);

            result = nesting.Solve("(()())");
            Assert.AreEqual(1, result);

            result = nesting.Solve("");
            Assert.AreEqual(1, result);

            result = nesting.Solve("((()()))((()()))");
            Assert.AreEqual(1, result);

            result = nesting.Solve("()");
            Assert.AreEqual(1, result);

            result = nesting.Solve("()(");
            Assert.AreEqual(0, result);

            result = nesting.Solve("(");
            Assert.AreEqual(0, result);

            result = nesting.Solve("())(()");
            Assert.AreEqual(0, result);
        }

    }
}
