using System;

namespace MoneyMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("How much money would you like to convert to coins?");
            string userAmount = Console.ReadLine();
            double userAmountDouble = Convert.ToDouble(userAmount);
            Console.WriteLine($"{userAmountDouble} is equal to...");
        }
    }
}
