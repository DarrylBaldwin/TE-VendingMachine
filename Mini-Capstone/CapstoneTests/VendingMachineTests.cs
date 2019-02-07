using Capstone.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
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

        [TestMethod]
        public void Test_Feed_Money()
        {
            Assert.AreNotEqual(1, test.CurrentMoney);
            test.FeedMoney(1);
            Assert.AreEqual(1, test.CurrentMoney);
            test.FeedMoney(5);
            Assert.AreEqual(6, test.CurrentMoney);
        }

        [TestMethod]
        public void Test_Log_File_Is_Growing_After_Each_Log()
        {
            string[] startingLines = File.ReadAllLines(@"C:\VendingMachine\Log.txt");
            int startingLinesCount = startingLines.Length;

            test.WriteToLog("Test Log Item");

            string[] newLines = File.ReadAllLines(@"C:\VendingMachine\Log.txt");
            int newLinesCount = newLines.Length;

            Assert.AreNotEqual(startingLinesCount, newLinesCount);
        }
    }
}
