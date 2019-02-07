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
        private string filePath = @"C:\VendingMachine\vendingmachine.csv";

        // Constructor
        public VendingMachine()
        {
            string[] itemInfo = new string[3];
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        itemInfo = line.Split('|');
                        items.Add(new VendingMachineItem(itemInfo[1], Decimal.Parse(itemInfo[2]), itemInfo[0]));
                    }
                }
            }
            catch(IOException e)
            {}
        }

        // Methods
        public override string ToString()
        {
            string output = "";
            foreach(VendingMachineItem item in items)
            {
                output += item.ToString() + "\n";
            }
            return output;
        }
    }
}
