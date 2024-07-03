using System;

namespace MeuApp
{

    class Program
    {
        static void Main(string[] args)
        {
              // logic operators
              int x = 5;
              int y = 12;
              Console.WriteLine(( x > 25) && (y > 10) ); // && os dois tem que ser T para a saida ser T
              Console.WriteLine((x > 25) || (y > 10)); // || somente um tem que ser T para o resultado ser T
              Console.WriteLine(!(x > 25)); // Inverte o resultado, "não é maior que || não é menor que";

              Console.WriteLine(" ");

              int a = 12;
              bool e = (a > 25) && (a < 40); // False
              bool ou = ( a > 25) || ( a < 40); // True
              bool neg = !(x < 25); // False

              Console.WriteLine(e);
              Console.WriteLine(ou);
              Console.WriteLine(neg);
        }

    }
}