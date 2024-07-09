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

            int i = 0;
            do{
                Console.WriteLine(i);
                i++;
            }
            while(i <= x);
            Console.WriteLine(" ");

            // infinito
            // var valor = 0;
            // do{
            //     Console.WriteLine(valor);
            //     valor++;
            // }
            // while(true);
        }

    }
}