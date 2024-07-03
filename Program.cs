using System;

namespace MeuApp
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("");
            string num = Console.ReadLine();
            int x = Convert.ToInt32(num);

            Console.Write("");
            string num2 = Console.ReadLine();
            int y = Convert.ToInt32(num2);
            
            int soma = x + y;
            Console.WriteLine("X = " + soma);

        }

    }
}