using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ServiceLib.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void 一天小費10元()
        {
            var stateroomService = new StateroomService();
            var startTime = new DateTime(2018, 7, 7);
            var endTime = new DateTime(2018, 7, 7);
            var totalAmount = stateroomService.TotalAmount(startTime, endTime);
            Assert.AreEqual(10m, totalAmount);
        }
    }
}