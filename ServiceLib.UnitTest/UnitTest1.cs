using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ServiceLib.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private StateroomService _stateroomService;

        [TestInitialize]
        public void TestInit()
        {
            _stateroomService = new StateroomService();
        }

        [TestMethod]
        public void 一天小費10元()
        {
            AmountShouldBe(10m, new DateTime(2018, 7, 7), new DateTime(2018, 7, 7));
        }

        [TestMethod]
        public void 三天小費30元()
        {
            AmountShouldBe(30m, new DateTime(2018, 7, 7), new DateTime(2018, 7, 9));
        }

        private void AmountShouldBe(decimal expected, DateTime startTime, DateTime endTime)
        {
            var totalAmount = _stateroomService.TotalAmount(new Period(startTime, endTime));
            Assert.AreEqual(expected, totalAmount);
        }
    }
}