﻿using System;
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

        [TestMethod]
        public void ConsumedMessageTest_C_Should_Be_Glug_Glug_1()
        {
            item = new VendingMachineItem("Mountain Melter", 1.50M, "C3");

            Assert.AreEqual("Glug Glug, Yum", item.ConsumedMessage);
        }

        [TestMethod]
        public void ConsumedMessageTest_C_Should_Be_Glug_Glug_2()
        {
            item = new VendingMachineItem("Cola", 1.25M, "C1");

            Assert.AreEqual("Glug Glug, Yum", item.ConsumedMessage);
        }

        [TestMethod]
        public void ConsumedMessageTest_D_Should_Be_Chew_Chew_()
        {
            item = new VendingMachineItem("Chiclets", 0.75M, "D3");

            Assert.AreEqual("Chew Chew, Yum", item.ConsumedMessage);
        }

        [TestMethod]
        public void ConsumedMessageTest_D_Should_Be_Chew_Chew_2()
        {
            item = new VendingMachineItem("Little League Chew", 0.95M, "D2");

            Assert.AreEqual("Chew Chew, Yum", item.ConsumedMessage);
        }

        [TestMethod]
        public void PurchaseItemTest_Quantity_More_Than_1_Should_Be_True()
        {
            item = new VendingMachineItem("Little League Chew", 0.95M, "D2");

            Assert.AreEqual(5, item.QuantityRemaining);

            item.PurchaseItem();
            Assert.AreEqual(4, item.QuantityRemaining);
            Assert.AreEqual(true, item.PurchaseItem());
        }
    }
}
