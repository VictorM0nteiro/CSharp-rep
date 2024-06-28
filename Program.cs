using System;

namespace MeuApp
{

    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = num1*10;
            float num3 = (float)num2/3; // Explicit conversion, is necessary to declare the type before, in order to convert non-compatible types;
            double num4 = (double)num3/7;
            Console.WriteLine(num3);
            Console.WriteLine(num4);
        }

    }
}