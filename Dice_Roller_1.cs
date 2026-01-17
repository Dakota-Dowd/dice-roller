using System;
using System.Collections.Generic;
using System.Text;

namespace Mission_2_Assignment
{
    // A class to roll dice and return results
    internal class DiceRoller
    {
        private Random rnd = new Random();

        // Method to roll two dice
        public int[] RollDice(int numRolls) // Accepts number of rolls from user
        {
            int[] counts = new int[13];
            // Rolls dice and stores sums
            for (int i = 0; i < numRolls; i++)
            {
                int die1 = rnd.Next(1, 7);
                int die2 = rnd.Next(1, 7);
                int sum = die1 + die2;
                counts[sum]++;
            }
            return counts;
        }
    }
}
