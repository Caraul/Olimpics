using Microsoft.VisualStudio.TestTools.UnitTesting;
using Labirint;
using System.Collections.Generic;

namespace LabirintTest
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void ExprTest()
        {
            var variables = new int[4] { 2, 3, 4, 5 };
            var postfix = new int[] { 2, 1, -3, 0, -2, 3, -1 };
            var expr1 = new Expr(postfix);
            Assert.AreEqual(expr1.CountExprNum(variables), 15);
        }
        [TestMethod]
        public void Room1Test()
        {
            var room1 = new Room1("1 2 0 7 2 1 -3 0 -2 3 -1");
            var variables = new int[4] { 2, 3, 4, 5 };
            Assert.AreEqual(room1.WalkedThrough(variables)[0], 15);
        }
        [TestMethod]
        public void Room2Test()
        {
            var room2_1 = new Room2("1 2 3 4 7 2 1 -3 0 -2 3 -1");
            var room2_2 = new Room2("1 2 3 4 7 2 1 -2 0 -2 3 -2");
            var room2_3 = new Room2("1 2 3 4 1 4");
            var variables = new int[5] { 2, 3, 4, 5, 0 };
            Assert.AreEqual(room2_1.IndexOfTunnelWhichPigGo(variables), 2);
            Assert.AreEqual(room2_2.IndexOfTunnelWhichPigGo(variables), 3);
            Assert.AreEqual(room2_3.IndexOfTunnelWhichPigGo(variables), 4);
        }
        [TestMethod]
        public void MapTest()
        {
            var map = new Map("3 4 5 2 4");
            Assert.AreEqual(map.tunnels.Length, 5);
            Assert.AreEqual(map.rooms1.Length, 3);
            Assert.AreEqual(map.rooms2.Length, 4);
            Assert.IsTrue(map.tunnels[1].HasExit);
            Assert.IsTrue(map.tunnels[2].HasExit);
        }
    }
}
