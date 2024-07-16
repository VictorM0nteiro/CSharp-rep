using System;

namespace MeuApp
{

    class Program
    {
        static void Main(string[] args)
        {
            MeuMetodo();
            string names = RetornaNome("Victor", "Monteiro");
            Console.WriteLine(names);
        }

        static void MeuMetodo()
        {
            Console.WriteLine("C# is cool");
        }

        static string RetornaNome(string nome, string sobrenome, int idade = 18, bool teste = false)
        {
        // Definindo parametros para retorno do nome e sobrenome
        return nome + " " + sobrenome + " tem " + idade.ToString() + " e " + teste.ToString();
        }
    }

}