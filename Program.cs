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
            int gold = 10;
            int silver = 5;
            double fit10 = Math.Floor(userAmountDouble / 10);
            double leftOver = userAmountDouble % 10;
            double silverCoins = Math.Floor(leftOver / silver);
            double remainder = leftOver % silver;

            Console.WriteLine($"Gold Coins: {fit10}");
            Console.WriteLine($"Silver Coins:{silverCoins}");
            Console.WriteLine($"Bronze Coins: {remainder}");
        }
    }
}
