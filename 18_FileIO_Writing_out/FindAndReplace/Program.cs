using System;
using System.IO;

namespace FindAndReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable declarations
            string sourceFilePath = "";
            string destinationFilePath = "";
            int numberOfOccurences = 0;

            Console.Write("Search Phrase: ");
            string searchPhrase = Console.ReadLine();

            Console.Write("Replace Phrase: ");
            string replacePhrase = Console.ReadLine();

            bool validSource = false;
            while (!validSource)
            {
                Console.WriteLine("Source File path:");
                sourceFilePath = Console.ReadLine();

                validSource = File.Exists(sourceFilePath);
                if(!validSource)
                {
                    Console.WriteLine("Not a valid file, press enter to try again.");
                    Console.ReadLine();
                }
            }

            bool validDestination = false;
            while (!validDestination)
            {
                Console.WriteLine("Destination File Path:");
                destinationFilePath = Console.ReadLine();

                validDestination = !File.Exists(destinationFilePath);
                if (!validDestination)
                {
                    Console.WriteLine("Error: There is already a file at this destination.");
                    Console.WriteLine("Press enter to exit");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }

            try
            {
                using (StreamReader sr = new StreamReader(sourceFilePath))
                {
                    using (StreamWriter sw = new StreamWriter(destinationFilePath))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();

                        }
                    }
                }
            }
            catch
            {

            }

            Console.ReadLine();
        }
    }
}
