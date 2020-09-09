using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();

            myArrayList.Add(10);
            myArrayList.Add(11.5);
            myArrayList.Add("This is a string");

            myArrayList.AddRange(new ArrayList() { 20, 17.7, "This is another string" });

            myArrayList.Remove(10);
            myArrayList.RemoveAt(0);
            myArrayList.RemoveRange(1, 2);

            foreach(var value in myArrayList)
            {
                Console.WriteLine(value);
            }
        }
    }
}
