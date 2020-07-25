using System;
using static System.Console;


namespace Increment_Decrement
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Increment");
            for(int a = 0; a <= 10; a++) //loops the following code with a starting value for a of 0 until a is no longer less than or equal to 10, incrementing a by 1 each time
            {
                WriteLine(a); //outputs the value of a on a new line
            }
            WriteLine("Decrement:");
            for (int b = 15; b > 0; b--) 
            {
                WriteLine(b); 
            }
        }
    }
}
