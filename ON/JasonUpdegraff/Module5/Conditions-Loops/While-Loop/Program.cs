using System;
using static System.Console;

namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            WriteLine("Guess a number (1-10)");

            while(true)
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == num)
                {
                    WriteLine("Your guess was correct!");
                    break;
                }
                else if(userInput < 1 || userInput > 10)
                {
                    WriteLine("That number is not between 1 and 10!");
                }
                else
                {
                    WriteLine("You guessed wrong. Guess again: ");
                }
            }
        }
    }
}
