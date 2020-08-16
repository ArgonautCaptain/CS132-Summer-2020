using System;
using System.Numerics;
using static System.Console;

namespace String
{
    class Program
    {
        static void Main()
        {
            string Welcome = "Welcome to ";
            string CourseName = "CS131";
            string message = Welcome + CourseName;

            for (int i = 0; i < message.Length; i++)
            {
                if(i % 2 == 0) //challenge
                {
                    Write(message[i]);
                }    
            }
        }
    }
}