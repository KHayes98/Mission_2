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

                //Console.WriteLine(i + ": " + die_1);
                //Console.WriteLine(i + ": " + die_2);

                rollTotals[i] = die_1 + die_2;
            }

            /* int count_2 = 0;
            int count_3 = 0;
            int count_4 = 0;
            int count_5 = 0;
            int count_6 = 0;
            int count_7 = 0;
            int count_8 = 0;
            int count_9 = 0;
            int count_10 = 0;
            int count_11 = 0;
            int count_12 = 0; */

            int[] numCounter = new int[10];

            for (int i_inner = 0; i_inner < 10; i_inner++)
            {

                for (int i = 0; i < diceRolls; i++)
                {
                    //Console.WriteLine(i + ": " + rollTotals[i]);


                    if (rollTotals[i] == 2)
                    {
                        numCounter[0]++;
                    }

                    if (rollTotals[i] == 3)
                    {
                        numCounter[1]++;
                    }

                    if (rollTotals[i] == 4)
                    {
                        numCounter[2]++;
                    }

                    if (rollTotals[i] == 5)
                    {
                        numCounter[3]++;
                    }

                    if (rollTotals[i] == 6)
                    {
                        numCounter[4]++;
                    }

                    if (rollTotals[i] == 7)
                    {
                        numCounter[5]++;
                    }

                    if (rollTotals[i] == 8)
                    {
                        numCounter[6]++;
                    }

                    if (rollTotals[i] == 9)
                    {
                        numCounter[7]++;
                    }

                    if (rollTotals[i] == 10)
                    {
                        numCounter[8]++;
                    }

                    if (rollTotals[i] == 11)
                    {
                        numCounter[9]++;
                    }

                    if (rollTotals[i] == 12)
                    {
                        numCounter[10]++;
                    }

                }

                Console.WriteLine(i_inner + ": " + numCounter[i_inner]);
            }

            /* Console.WriteLine("2: " + ((count_2 / diceRolls) * 100));
            Console.WriteLine("3: " + ((count_3 / diceRolls) * 100));
            Console.WriteLine("4: " + ((count_4 / diceRolls) * 100));
            Console.WriteLine("5: " + ((count_5 / diceRolls) * 100));
            Console.WriteLine("6: " + ((count_6 / diceRolls) * 100));
            Console.WriteLine("7: " + ((count_7 / diceRolls) * 100));
            Console.WriteLine("8: " + ((count_8 / diceRolls) * 100));
            Console.WriteLine("9: " + ((count_9 / diceRolls) * 100));
            Console.WriteLine("10: " + ((count_10 / diceRolls) * 100));
            Console.WriteLine("11: " + ((count_11 / diceRolls) * 100));
            Console.WriteLine("12: " + ((count_12 / diceRolls) * 100)); */



            /* for (int i_outer = 2; i_outer < 13; i_outer++)
            {
                for (int i = 0; i < diceRolls; i++)
                {
                    while (rollTotals[i] == i)
                    {
                        Console.WriteLine(i_outer + ": " + )
                    }
                }
            } */


        }
    }
}
