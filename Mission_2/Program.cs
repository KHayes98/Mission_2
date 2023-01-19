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
        }
    }
}
