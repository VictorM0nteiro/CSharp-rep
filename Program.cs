using System;

namespace MeuApp
{
    
    class Program
    {
        static void Main(string[] args)
        {   

            //int nome = null; Cannot convert null to 'int' because it is a non-nullable value type

            int? nome = null; // In order of being converted its necessary to use '?';
            Console.WriteLine(nome);

            int? idade = 0; // devo colocar na primeira inicialização se tiver intenção de usar;
            Console.WriteLine(idade);
            idade = null; // A qualquer momento posso mudar para um NULL, mas é ncessário na primeira inicialização ter o '?';
            Console.WriteLine(idade);
            idade = 18;
            Console.WriteLine(idade);
        }
        
    }
}