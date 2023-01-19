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

                rollTotals[i] = die_1 + die_2;
            }

            int[] numCounter = new int[11];


            for (int i_inner = 0; i_inner < 11; i_inner++)
            {

                for (int i = 0; i < diceRolls; i++)
                {
                    if (rollTotals[i] == 2)
                    {
                        numCounter[0]++;
                    }
                    else if (rollTotals[i] == 3)
                    {
                        numCounter[1]++;
                    }
                    else if (rollTotals[i] == 4)
                    {
                        numCounter[2]++;
                    }
                    else if (rollTotals[i] == 5)
                    {
                        numCounter[3]++;
                    }
                    else if (rollTotals[i] == 6)
                    {
                        numCounter[4]++;
                    }
                    else if (rollTotals[i] == 7)
                    {
                        numCounter[5]++;
                    }
                    else if (rollTotals[i] == 8)
                    {
                        numCounter[6]++;
                    }
                    else if (rollTotals[i] == 9)
                    {
                        numCounter[7]++;
                    }
                    else if (rollTotals[i] == 10)
                    {
                        numCounter[8]++;
                    }
                    else if (rollTotals[i] == 11)
                    {
                        numCounter[9]++;
                    }
                    else if (rollTotals[i] == 12)
                    {
                        numCounter[10]++;
                    }

                }
                Console.WriteLine(i_inner + 2 + ": " + numCounter[i_inner]/(i_inner + 1));
            }

        }
    }
}
