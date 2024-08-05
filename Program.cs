using System;

namespace MeuApp
{

    class Program
    {
        static void Main(string[] args)
        {
            // Value types
            int x = 25;
            int y = x;
            Console.WriteLine(x);
            Console.WriteLine(y);

            x = 32;
            Console.WriteLine(x);
            Console.WriteLine(y);// doesnt change because it aint the same as x, its a copy, its adress on the memory is another one


            Console.WriteLine(" ");

            //reference types
            var arr = new string[2];
            arr[0] = "item 1";
            var arr2 = arr;
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

            arr[0] = "item 2";
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

        }
    }

}