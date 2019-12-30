using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hepta;
using System.Collections.Generic;

namespace HeptaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HeptaArray()
        {
            List<int> hepta = Program.InitHepta();
            Assert.AreEqual(hepta[7] == 1, true);
            Assert.AreEqual(hepta[14] == 127, true);
        }
        [TestMethod]
        public void BitString()
        {
            Assert.AreEqual(Program.bit(-1, 9) == "111010001", true);
        }
    }
}
