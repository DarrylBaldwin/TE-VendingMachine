using Capstone.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes.Tests
{
    [TestClass]
    public class VendingMachineTests
    {
        VendingMachine test = new VendingMachine();

        [TestMethod]
        public void Constructor_Tests()
        {
            Assert.IsNotNull(test);
        }

        [TestMethod]
        public void Test_First_Results_of_To_String()
        {
            string[] outputLines = test.ToString().Split("\n");
            Assert.AreEqual("A1: Potato Crisps (5 Remaining), 3.05", outputLines[0]);
            Assert.AreEqual("B1: Moonpie (5 Remaining), 1.80", outputLines[4]);
        }
    }
}
