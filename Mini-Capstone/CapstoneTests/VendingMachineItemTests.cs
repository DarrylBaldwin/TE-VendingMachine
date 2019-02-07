using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Capstone.Classes.Tests
{
    [TestClass()]
    public class VendingMachineItemTests
    {
        VendingMachineItem item;


        [TestMethod]
        public void ConsumedMessageTest_A_Should_Be_Crunch_Crunch()
        {
            item = new VendingMachineItem("Potato Crisps", 3.05M, "A1");

            Assert.AreEqual("Crunch Crunch, Yum", item.ConsumedMessage);

        }
    }
}
