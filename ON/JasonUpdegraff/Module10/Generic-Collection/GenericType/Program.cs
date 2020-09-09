using System;

namespace GenericType
{
    class Program
    //{
    //    class StoreInt
    //    {
    //        public int num1 { set; get; }
    //        public int num2 { set; get; }
    //    }
    //    class StoreString
    //    {
    //        public string strg1 { set; get; }
    //        public string strg2 { set; get; }
    //    }

    //    static void Main()
    //    {
    //        StoreInt MyInt = new StoreInt { num1 = 1, num2 = 3 };
    //        StoreString MyStrg = new StoreString { strg1 = "CS", strg2 = "131" };

    //        Console.WriteLine(MyInt.num1 + "," + MyInt.num2);
    //        Console.WriteLine(MyStrg.strg1 + " " + MyStrg.strg2);
    //    }
    //}
    {
        class StoreAnything <T, U, V>
        {
            public T Var1 { set; get; }
            public U Var2 { set; get; }
            public V Var3 { set; get; }
            //challenge
        }

        static void Main()
        {
            StoreAnything<string, int, char> MyVar1 = new StoreAnything<string, int, char> { Var1 = "CS", Var2 = 131, Var3 = '!'};
            Console.WriteLine(MyVar1.Var1 + MyVar1.Var2 + MyVar1.Var3);
        }
    }
}
