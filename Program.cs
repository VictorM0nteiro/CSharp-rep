using System;

namespace MeuApp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var num = 2.5; // double até 64 bits
            double num1 = 2.5; // double até 64 bits

            var num3 = 2500.00f; // 32 bits
            float num2 = 2.500f; // para utilizar o float é necessário colocar a notação f

            var num4 = 2500.0m; // 128 bits
            decimal num5 = 2500.000m; // para utilizar o decimal é necessário colocar a notação m


            Console.WriteLine(num);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);


        }
    }
}