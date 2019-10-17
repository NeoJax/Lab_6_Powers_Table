// ===============================
// AUTHOR     : Jonathan Lubaway
// CREATE DATE: October 17th, 2019
// PURPOSE    : Display a table of powers
// ===============================
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab_6_Powers_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a crime against art that I did for some reason
            Console.WriteLine("" +
                "|                    ____          _______              \n" +
                "|      |-----       /    \\        |      |    |\\     |\n" +
                "|      |           /      \\       |      |    | \\    |\n" +
                "|      |-----     /--------\\      |------|    |  \\   |\n" +
                "|      |         /          \\     |    \\      |   \\  |\n" +
                "|      |        /            \\    |     \\     |    \\ |\n" +
                "|_____ |------ /              \\   |      \\    |     \\|\n");
            Console.WriteLine("your Squares and Cubes");
            CheckForInteger();
        }

        // This method checks to make sure that the user has actually inputted an integer
        public static void CheckForInteger()
        {
            // This is regex to make sure the input is a number
            string hasNumbers = @"\d";
            Console.Write("Please enter an integer: ");
            string userContinue = Console.ReadLine();

            // This repeats if an integer is not put in
            if (Regex.IsMatch(userContinue, hasNumbers))
            {
                Console.WriteLine();
                PowersTable(int.Parse(userContinue) + 1);
            }
            else
            {
                Console.WriteLine("Please input a valid number");
                CheckForInteger();
            }
        }

        // This method generates the powers table
        public static void PowersTable(int value)
        {
            // Top of the table
            Console.WriteLine("_________________________");
            Console.WriteLine("|Number\tSquared\tCubed\t|");
            Console.WriteLine("|=======================|");

            // Nested for loop that makes the table while calculating the powers
            for (int i = 1; i < value; i++)
            {
                Console.Write("|");
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write(Math.Pow(i, j) + "\t");
                }
                Console.Write("|");
                Console.WriteLine();
            }
            // Bottom of the table and sends the user to the continue method
            Console.WriteLine("-------------------------");
            GetContinue();
        }

        // This method determines if someone wants to continue running more tables
        public static void GetContinue()
        {
            Console.WriteLine("Would you like to continue? (y/n)");
            string input = Console.ReadLine();

            // If a user wants to continue re-runs the check for an integer
            // Otherwise re-runs if an invalid input is put in
            if (input == "y")
            {
                CheckForInteger();
            }
            else if (input == "n")
            {
                Console.WriteLine("Hope you learned something.");
            }
            else
            {
                Console.WriteLine("Please enter a valid option");
                GetContinue();
            }
        }
    }
}
