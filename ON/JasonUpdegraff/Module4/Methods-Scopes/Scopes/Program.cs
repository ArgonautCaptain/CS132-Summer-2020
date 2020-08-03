using System;
using static System.Console;

namespace Scopes
{
    class Program
    {
        public static string Str2;
        static void ReturnString(string Str1)
        {
            Str2 = "Programming in C#";

            Write(Str1);
        }
        static void Main(string[] args)
        {
            ReturnString("CS131 ");
            WriteLine(Str2);
        }
    }
}
