using System;
using System.Globalization;

namespace MeuApp
{
    
    class Program
    {
        static void Main(string[] args)
        {   
             System.String nome = "Victor"; // original type
             string nome2 = "Victor"; // type alias, na prática são a mesma coisa;
 
             int idade = 18; // Alias
             Int32 idade2 = 18; // Original type

             Int128 num = 10000000000000000000; // alias;

             Console.WriteLine(nome);
             Console.WriteLine(nome2);

             Console.WriteLine(idade);
             Console.WriteLine(idade2);

             Console.WriteLine(num);
        }
        
    }
}