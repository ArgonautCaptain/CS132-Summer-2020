using System;
using static System.Console;

namespace Date_Time
{
    class Program
    {
        void ShowTime()
        {
            DateTime currentDate = DateTime.Now;
            bool leapYear = DateTime.IsLeapYear(2020);

            WriteLine(currentDate);
            Write("2020 is a leapYear: ");
            WriteLine(leapYear);
        }

        void GetPersonalInfo()
        {
            WriteLine("Enter your name: ");
            string name = ReadLine();

            WriteLine("What year were you born?");
            int birthYear = Convert.ToInt32(Console.ReadLine());

            int age = (Convert.ToInt32(DateTime.Now.Year) - birthYear);

            WriteLine("Here is what we know from your inputs: ");
            WriteLine("Your name: {0}", name);
            WriteLine("Today is: {0}", DateTime.Now.ToShortDateString());
            WriteLine("Your age: {0}", age);

        }

        void NumberofDays()
        {
            DateTime currentDate = DateTime.Now;
            int currentYear = currentDate.Year;
            int currentMonth = currentDate.Month;
            string month = currentDate.ToString("MMMM");
            WriteLine("The month is {0} ({1})", month, currentMonth);
            int days = DateTime.DaysInMonth(currentYear, currentMonth);
            WriteLine("There are {0} days in this month", days);


        }
        
        static void Main()
        {
            Program MyProgram = new Program();
            //MyProgram.GetPersonalInfo();
            MyProgram.NumberofDays();

        }
    }
}
