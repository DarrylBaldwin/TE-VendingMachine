using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class UserInterface
    {
        private VendingMachine vendingMachine = new VendingMachine();

        public void RunInterface()
        {
            bool done = false;
            while (!done)
            {
                int choice = 0;
                Console.Clear();
                Console.WriteLine("Welcome to Vendo-Matic 7000!\n");
                Console.WriteLine("(1) Display Vending Machine Items");
                Console.WriteLine("(2) Purchase");
                Console.WriteLine("(3) End");
                Console.Write("\nPlease choose an option: ");

                string userInput = Console.ReadLine();
                try
                {
                    choice = int.Parse(userInput);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Invalid input\n{e.Message}");
                    Console.WriteLine("Press enter to return to the main menu");
                    Console.ReadLine();
                }

                if(choice == 1)
                {
                    //PrintAllItems();
                }
                else if(choice == 2)
                {
                    //PurchaseMenu();
                }
                else if(choice == 3)
                {
                    done = true;
                }
            }

        }
    }
}
