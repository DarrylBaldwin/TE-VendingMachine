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
                choice = IsValidInt(userInput);

                if(choice == 1)
                {
                    //PrintAllItems();
                }
                else if(choice == 2)
                {
                    PurchaseMenu();
                }
                else if(choice == 3)
                {
                    done = true;
                }
            }

        }

        //////// Menu Methods ////////
        void PurchaseMenu()
        {
            bool done = false;
            int choice = 0;
            while(!done)
            {
                Console.Clear();
                Console.WriteLine("Purchase Menu\n");
                Console.WriteLine("(1) Feed Money");
                Console.WriteLine("(2) Select Product");
                Console.WriteLine("(3) Finish Transaction");
                //TODO: create Console.WriteLine($"\nCurrent Money Provided: {vendingMachine.CurrentMoney}");
                Console.Write("\nPlease choose an option: ");

                string userInput = Console.ReadLine();
                choice = IsValidInt(userInput);

                if (choice == 1)
                {
                    FeedMoney();
                }
                else if (choice == 2)
                {
                    SelectProductMenu();
                }
                else if (choice == 3)
                {
                    FinishTransaction();
                    done = true;
                }
            }
        }

        void PrintAllItems()
        {
            Console.Clear();
            //TODO: add ToString ovverride Console.WriteLine(VendingMachine.ToString());
        }

        void FeedMoney()
        {
            Console.Clear();
            Console.Write("Enter bill amount: ");
            string userInput = Console.ReadLine();
            int money = IsValidInt(userInput);

            if(money == 1 || money == 2 || money == 5 || money == 10 || money == 20)
            {
                //TODO: add method vendingMachine.FeedMoney(money);
            }
            else
            {
                Console.WriteLine("That doesn't appear to be a valid bill.\nPress enter to return to the Purchase Menu");
                Console.ReadLine();
            }
        }

        void SelectProductMenu()
        {
            PrintAllItems();
            Console.WriteLine("\nEnter the item you would like to purchase (ex. A1): ");
            string userInput = Console.ReadLine();
            //TODO: create method in VendingMachine Console.WriteLine(vendingMachine.DispenseProduct(userInput));
            Console.WriteLine("Press enter to return to the Purchase Menu.");
            Console.ReadLine();
        }

        void FinishTransaction()
        {
            //TODO: create class Console.WriteLine(VendingMachine.DispenseChange())
        }



        //////// Other Methods ////////
        int IsValidInt(string userInput)
        {
            int choice = 0;
            try
            {
                choice = int.Parse(userInput);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Invalid input\n{e.Message}");
                Console.WriteLine("Press enter to return to the previous menu");
                Console.ReadLine();
            }
            return choice;
        }
    }
}
