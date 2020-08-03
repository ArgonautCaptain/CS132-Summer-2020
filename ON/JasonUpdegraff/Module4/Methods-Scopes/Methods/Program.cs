using System;
using static System.Console;

namespace Methods
{
    class Program
    {
        //public static int Adding(int num1, int num2)
        //{
        //    int sum = num1 + num2;
        //    return sum;
        //}
        //challenge
        public static int Remainder(int a, int b)
        {
            int Mod = a % b;
            return Mod;
        }
        static void Main()
        {
            WriteLine(Remainder(20, 13));
        }
    }
}
