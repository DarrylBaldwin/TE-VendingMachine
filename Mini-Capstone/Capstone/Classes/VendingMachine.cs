using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone.Classes
{
    public class VendingMachine
    {
        public decimal CurrentMoney { get; private set; }

        private List<VendingMachineItem> items = new List<VendingMachineItem>();
        private static string filePath = @"C:\VendingMachine";
        private string inventory = Path.Combine(filePath, "vendingmachine.csv");
        private string logFile = Path.Combine(filePath, "Log.txt");
        private string salesReport = Path.Combine(filePath, "SalesReport.txt");

        // Constructor
        public VendingMachine()
        {
            string[] itemInfo = new string[3];
            try
            {
                using (StreamReader sr = new StreamReader(inventory))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        itemInfo = line.Split('|');
                        items.Add(new VendingMachineItem(itemInfo[1], Decimal.Parse(itemInfo[2]), itemInfo[0]));
                    }
                }
            }
            catch (IOException e)
            { }
        }

        // Methods
        public override string ToString()
        {
            string output = "";
            foreach (VendingMachineItem item in items)
            {
                output += item.ToString() + "\n";
            }
            return output;
        }

        public string DispenseChange()
        {
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;

            while (CurrentMoney > 0)
            {
                if (CurrentMoney - 0.25M >= 0)
                {
                    CurrentMoney -= 0.25M;
                    quarters++;
                }
                else if (CurrentMoney - 0.10M >= 0)
                {
                    CurrentMoney -= 0.10M;
                    dimes++;
                }
                else if (CurrentMoney - 0.05M >= 0)
                {
                    CurrentMoney -= 0.00M;
                    nickels++;
                }
            }

            return $"Your change is: {quarters} quarters, {dimes} dimes, {nickels} nickels";
        }

        public void FeedMoney(int money)
        {
            CurrentMoney += money;
            string logLine = $"FEED MONEY: {money.ToString("c2")}    {CurrentMoney}";
            WriteToLog(logLine);
        }

        public bool WriteToLog(string logLine)
        {
            DateTime dateTime = DateTime.Now;
            string output = dateTime + " " + logLine;

            try
            {
                using (StreamWriter sw = new StreamWriter(logFile))
                {
                    sw.WriteLine(output, false);
                    return true;
                }
            }
            catch (IOException e)
            {
                return false;
            }
        }

        public string SalesReport(string reportName)
        {
            DateTime dateTime = DateTime.Now;
            string output = dateTime;
            try
            {
                using (StreamWriter sw = new StreamWriter(salesReport))
                {

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
