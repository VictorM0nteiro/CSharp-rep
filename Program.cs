using System;

namespace MeuApp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            short num = -10; //pode numeros positivos e negativos até 16 bits
            ushort num2 = 10; // pode somente numeros positivos até 16 bits

            int num3 = -1000000000; // pode numeros positivos e negativos até 32 bits
            uint num4 = 1000000000; // pode somente numeros positivos até 32 bits

            long num5 = -1000000000000000000; // pode numeros positivos e negativos até 64 bits
            ulong num6 = 10000000000000000000; // pode somente numeros positivos até 64 bits


            Console.WriteLine(num);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);
            Console.WriteLine(num6);


        }
    }
}