using System;

namespace MeuApp
{

    class Program
    {
        static void Main(string[] args)
        {
             int x = 0; // atribuição;
             x += 5; // x = x + 5;
             x -= 1; // x = x-1;
             x *= 10; // x = x*10;
             x /= 2; // x = x/2;
             int y = 0;
             y++; // Soma 1

             Console.WriteLine(x); // Resultado de todas as atribuições sucessivas anteriores
             Console.WriteLine(y); // resultado 1;
        }

    }
}