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

        [TestMethod]
        public void ConsumedMessageTest_A_Should_Be_Crunch_Crunch_2()
        {
            item = new VendingMachineItem("Stackers", 1.45M, "A2");

            Assert.AreEqual("Crunch Crunch, Yum", item.ConsumedMessage);
        }

        [TestMethod]
        public void ConsumedMessageTest_B_Should_Be_Munch_Munch()
        {
            item = new VendingMachineItem("Moonpie", 1.80M, "B1");

            Assert.AreEqual("Munch Munch, Yum", item.ConsumedMessage);
        }

        [TestMethod]
        public void ConsumedMessageTest_B_Should_Be_Munch_Munch_2()
        {
            item = new VendingMachineItem("Cowtales", 1.50M, "B2");

            Assert.AreEqual("Munch Munch, Yum", item.ConsumedMessage);
        }
    }
}
