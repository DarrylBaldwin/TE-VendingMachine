using System;
using System.IO;

namespace file_io_part1_exercises_pair
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = "c:\\HappyPlace";
            string fileName = "alices_adventures_in_wonderland.txt";

            string fullpath = Path.Combine(folder, fileName);

            int numberOfWords = 0;
            int numberOfSenteneces = 0;

            using (StreamReader reader = new StreamReader(fullpath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    foreach (char c in line)
                    {
                        if (c == ' ')
                        {
                            numberOfWords++;
                        }
                        else if ((c == '.') || (c == '!') || (c == '?'))
                        {
                            numberOfSenteneces++;
                        }
                    }
                }
            }
        }
    }
}
