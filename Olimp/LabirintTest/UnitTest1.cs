using Microsoft.VisualStudio.TestTools.UnitTesting;
using Labirint;
using System.Collections.Generic;

namespace LabirintTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ExprTest()
        {
            var variables = new List<int>() {2, 3, 4, 5};
            var postfix = "7 2 1 -3 0 -2 3 -1";
            var expr1 = new expr(postfix, variables);
            Assert.AreEqual(expr1.ExprNum, 15);
        }
    }
}
