using System;

namespace MeuApp
{

    class Program
    {
        static void Main(string[] args)
        {
            int soma = 25+22;
            int subtracao = 25 -22;
            int mult = 25*22;
            int div =  22 / 5; // Não é o caso mas a ordem de precêdencia é mult e div para depois sub e som

            Console.WriteLine(soma);
            Console.WriteLine(subtracao);
            Console.WriteLine(mult);
            Console.WriteLine(div); // A few examples of arithmetics operators
        }

    }
}