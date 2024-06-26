using System;

namespace MeuApp
{
    
    class Program
    {
        static void Main(string[] args)
        {   


            var idade = 25; //int
            idade = 26;
            //idade = "Victor"; Não posso implicitamente mudar algo que foi definido como INT para uma string
            var letra = 'b'; // haverá situações que criaremos um tipo complexo e o VAR economizará a quantidade de código;

            Console.WriteLine(idade);
            Console.WriteLine(letra);




        }
    }
}