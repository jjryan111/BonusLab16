using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string yesNo = "y";
            while (yesNo == "y" || yesNo == "Y")
            {
                int input = GetInput();
                for (int i = 1; i <= input; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                yesNo = ynInput();
            }
        }
        static string ynInput()
        {
            string input = "";
            bool invalid = true;
            while (invalid)
            {
                Console.WriteLine("");
                Console.WriteLine("Continue? (y/n): ");
                input = Console.ReadLine();
                if ((input == "y") || (input =="Y") || (input == "N") || (input == "n"))
                {
                    invalid = false;
                }
            }
            return input;
        }
        public static int GetInput()
        {
            bool validInput = false;
            int exitNum = 0;
            while (!validInput)
            {
                Console.WriteLine("Please enter an integer between 1 and 10: ");
                bool inp = int.TryParse(Console.ReadLine(), out exitNum);
                if (!inp || exitNum <= 0 || exitNum > 10)
                {
                    Console.WriteLine("That's not valid input!");
                }
                else
                {
                    validInput = true;
                }
            }
            return exitNum;
        }
    }
}
