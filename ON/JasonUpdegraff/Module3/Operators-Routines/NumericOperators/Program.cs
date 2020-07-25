using System;
using static System.Console;

namespace NumericOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20; //the variable num1 = 20
            int num2 = 77; //the variable num2 = 20
            float num3 = 5.2f; //the variable num3 = 5.2

            float sum = num1 + num2 + num3; //adds up all the variables
            int subtract = num2 - num1; // subtracts num1 from num2
            int multiply = num1 * num2; // multiplies num1 and num2
            float divide = num1 / num3; // divides num1 by num3
            int modulus = num2 % num1; // finds remainder when deviding num2 by num1

            WriteLine("Sum of 3 numbers is: " + sum); //outputs sum to the console
            WriteLine("77 - 20 is: " + subtract); //outputs difference to the console
            WriteLine("20 * 77 is: " + multiply); //outputs product to the console
            WriteLine("20 / 5.2 is: " + divide); //outputs quotient to the console
            WriteLine("77 % 20 is: "  + modulus); //outputs remainder to the console
        }
    }
}
