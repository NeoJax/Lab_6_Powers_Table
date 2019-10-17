using System;
using System.Text.RegularExpressions;

namespace Lab_6_Powers_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!");
            CheckForInteger();
        }

        public static void CheckForInteger()
        {
            string hasNumbers = @"\d";
            string userContinue = Console.ReadLine();
            
            if (Regex.IsMatch(userContinue, hasNumbers))
            {
                PowersTable(int.Parse(userContinue) + 1);
            }
            else
            {
                Console.WriteLine("Please input a valid number");
                CheckForInteger();
            }
        }

        public static void PowersTable(int value)
        {
            for (int i = 1; i < value; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(Math.Pow(i, j));
                }
            }
        }
    }
}
