using System;
using System.Collections.Generic;
using System.Text;

namespace Mission_2_Assignment 
{
    // A program to roll dice and print results
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get number of rolls from user
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
            int numRolls = int.Parse(Console.ReadLine() ?? "0");

            // Use a DiceRoller instance to create a list of rolls
            DiceRoller roller = new DiceRoller();
            int[] results = roller.RollDice(numRolls);

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {numRolls}.");

            //Loop throught the possible sums
            for (int sum = 2; sum <= 12; sum++)
            {
                int percent = (int)Math.Round(results[sum] * 100.00 / numRolls);
                Console.Write($"{sum}: ");
                // Print the stars
                for (int i = 0; i < percent; i++)
                    Console.Write("*");
                Console.WriteLine();
            }

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}

