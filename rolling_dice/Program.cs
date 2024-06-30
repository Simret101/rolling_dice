using System;

namespace rolling_dice
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Random random = new Random();
            int ans=0;
            int ans2=0;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Enter any key to roll a Dice.");
                Console.ReadKey();

                ans = random.Next(1, 7);
                Console.WriteLine("You rolled a " + ans);
                Console.WriteLine("....");
                ans2 = random.Next(1, 7);
                Console.WriteLine("Enemy rolled a " + ans2);
                if (ans2 > ans)
                {
                    ans2++;
                    Console.WriteLine("Enemy Won!");
                }
                else if (ans2 < ans)
                {
                    ans++;
                    Console.WriteLine("Player Won!");
                }

                else
                {

                    Console.WriteLine("It's a Tie!");
                }
                Console.WriteLine("The Score of this turn is:- Player " + ans + ". Enemy " + ans2);
                Console.WriteLine();
            }
            if (ans2 > ans)
            {
                
                Console.WriteLine("Enemy Won!");
            }
            else if (ans2 < ans)
            {
                
                Console.WriteLine("Player Won!");
            }

            else
            {

                Console.WriteLine("It's a Tie!");
            }
            Console.ReadLine();
        }
        }
}
