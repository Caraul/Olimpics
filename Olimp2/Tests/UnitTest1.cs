using Microsoft.VisualStudio.TestTools.UnitTesting;
using Olimp2;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void YearExceptionTest()
        {
            Assert.ThrowsException<System.Exception>(() => Program.FirstDayOfYear(1));
        }
        [TestMethod]
        public void program()
        {
            int ExpectedMonth = 1, ExpectedDay = 4;
            Program.prog(2018, 1);
            Assert.IsTrue(Program.month == ExpectedMonth && Program.dm == ExpectedDay);
        }
    }
}
