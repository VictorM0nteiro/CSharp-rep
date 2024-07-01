using System;

namespace MeuApp
{

    class Program
    {
        static void Main(string[] args)
        {
            
            int inteiro = int.Parse("100"); // Está convertendo a string para um inteiro
            int mult = inteiro*10; // como converteu para um inteiro torna poss´vel a multiplicação;
            Console.WriteLine(mult);

            double num = double.Parse("100,057");
            double divs = num/2;
            Console.WriteLine(divs);
        }

    }
}