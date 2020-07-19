using System;
using static System.Console;

namespace Arrays_Enums
{
    class Program
    {
        static void Main()
        {
            //int[] numbers = new int[5];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            //numbers[4] = 5;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Write(numbers[i] + " ");
            //}

            //foreach (int number in numbers)
            //{
            //    Write(number + " ");
            //}

            //Challenge:
            string[] Sentence = new string[4];
            Sentence[0] = "This";
            Sentence[1] = "is";
            Sentence[2] = "a";
            Sentence[3] = "string";

            foreach (string word in Sentence)
            {
                Write(word + " ");
            }
        }
    }
}
