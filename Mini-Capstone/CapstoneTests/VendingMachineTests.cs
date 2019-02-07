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
        [TestMethod]
        public void Constructor_Tests()
        {
            VendingMachine test = new VendingMachine();

            Assert.IsNotNull(test);
        }
    }
}
