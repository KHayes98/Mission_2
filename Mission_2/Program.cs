using System;

namespace Mission_2
{
    public class Program
    {
        static void Main (string[] args)
        {
            string ?userInput = "";
            int diceRolls = 0;

            Console.WriteLine("Welcome to the dice throwing simulator!");

            Console.WriteLine("How many dice rolls would you like to simulate?");
            userInput = Console.ReadLine();
            //Converts to int
            diceRolls= Convert.ToInt32(userInput);

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + diceRolls);

            Random r = new Random();

            int die_1 = 0;
            int die_2 = 0;

            int[] rollTotals = new int[diceRolls];

            for (int i = 0; i < diceRolls; i++)
            {
                die_1 = r.Next(1, 7);
                die_2 = r.Next(1, 7);

                Console.WriteLine(i + ": " + die_1);
                Console.WriteLine(i + ": " + die_2);

                rollTotals[i] = die_1 + die_2;
            }

            for (int i = 0; i < diceRolls; i++)
            {
                Console.WriteLine(i + ": " + rollTotals[i]);
            }

            for (int i_outer = 2; i_outer < 13; i_outer++)
            {
                
            }

            
        }
    }
}
