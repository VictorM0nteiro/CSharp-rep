using System;
using System.Threading.Channels;

namespace MeuApp
{
    
    class Program
    {
        static void Main(string[] args)
        {   

            // var quantidade = ?? // Para situações em que não saberei o tipo utilizar o OBJECT
            object quantidade = 2.5;
            quantidade = 3; // posso ficar coinvertendo sem nenhum problema double -> int
            quantidade = 5.5; // e vice versa também // basicamente ele pode ser qualquer coisa;

            object teste = "bom";
            teste = 'b'; // não limita strings -> chars e vice versa

            object teste2 = "good";
            teste2 = 'c';
            teste2 = 5555555555555555555; // posso converter em ints e double, floats etc;
            
            
            Console.WriteLine(quantidade);
            Console.WriteLine(teste);
            Console.WriteLine(teste2);




        }
    }
}