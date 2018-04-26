using CodingChallenge.Library.StacksQueues;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Tests.StacksQueues
{

    [TestClass]
    public class BracketsTests
    {

        [TestMethod]
        public void BracketsSolutionTest()
        {
            var brackets = new Brackets();
            int result = brackets.Solve("{[()()]}");
            Assert.AreEqual(1, result);

            result = brackets.Solve("([)()]");
            Assert.AreEqual(0, result);

            result = brackets.Solve("");
            Assert.AreEqual(1, result);

            result = brackets.Solve("{[()()]}{[()()]}");
            Assert.AreEqual(1, result);

            result = brackets.Solve("[]");
            Assert.AreEqual(1, result);

            result = brackets.Solve("[](");
            Assert.AreEqual(0, result);

            result = brackets.Solve("(");
            Assert.AreEqual(0, result);

            result = brackets.Solve("())(()");
            Assert.AreEqual(0, result);

        }

    }
}
