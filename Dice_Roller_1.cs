using System;
using System.Collections.Generic;
using System.Text;

namespace Mission_2_Assignment
{
    internal class DiceRoller
    {
        private Random rnd = new Random();

        // Returns an array where index is the sum(2-12)
        public int[] RollDice(int numRolls)
        {
            int[] counts = new int[13];
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
