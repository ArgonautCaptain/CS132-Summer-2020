using System;
using static System.Console;

namespace Conditions_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            Console.WriteLine("Guess a number (1-10)");
            int userinput = Convert.ToInt32(Console.ReadLine());

            if (userinput == num)
            {
                WriteLine("Your guess was correct!");
            }
            //challenge
            else if (userinput > 10)
            {
                WriteLine("Number must be between 1 and 10!!!");
            }
            else if (userinput != num)
            {
                WriteLine("You guessed wrong. Good luck next time!");
            }
        }
    }
}
