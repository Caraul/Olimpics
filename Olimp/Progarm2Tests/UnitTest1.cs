using Microsoft.VisualStudio.TestTools.UnitTesting;
using Olimp2;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void YearExceptionTest1()
        {
            Assert.ThrowsException<System.Exception>(() => Program2.DayInWeek(1901));
        }
        [TestMethod]
        public void YearExceptionTest2()
        {
            Assert.ThrowsException<System.Exception>(() => Program2.DayInWeek(2038));
        }
        [TestMethod]
        public void NewMonth()
        {
            Program2.DayOfMonth = 32;
            Program2.month = 1;
            Program2.DayInWeek(2018);
            Assert.AreEqual(1, Program2.DayOfMonth);
            Assert.AreEqual(2, Program2.month);
        }
        [TestMethod]
        public void NoWeekendWithThisNumber()
        {
            Program2.month = 12;
            Program2.DayOfMonth = 32;
            Assert.AreEqual(0, Program2.DayInWeek(2018));
        }
        [TestMethod]
        public void ThirdWeekend()
        {
            Program2.month = 1;
            Program2.DayOfMonth = 1;
            Program2.DayOfWeek = Program2.DayInWeek(2018);
            Assert.AreEqual((16, 1), Program2.NumOfBonusWeekend(3, 2018));
        }
    }
}