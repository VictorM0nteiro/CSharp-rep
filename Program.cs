using System;

namespace MeuApp
{

    class Program
    {
        static void Main(string[] args)
        {
            // Convertendo uma string em um inteiro
            string numeroString = "123";
            int numeroInteiro = Convert.ToInt32(numeroString); //Converte a string "123" para o inteiro 123
            Console.WriteLine(numeroInteiro); //Saida: 123;

            // Convertendo um double em um inteiro
            double numerodouble = 123.45;
            int numeroInteiro2 = Convert.ToInt32(numerodouble); // Converte o double 123.45 para o inteiro 123 (arredonda para o valor inteiro mais próximo)
            Console.WriteLine(numeroInteiro2); // Saída: 123

            //Convertendo um booleano em uma string
            bool verdadeiroFalso = true;
            string booleanoString = Convert.ToString(verdadeiroFalso); // Converte o booleano true para a string "True"
            Console.WriteLine(booleanoString); // Saída: True

            // Convertendo uma string em um datetime
            string dataString = "2024-07-01  19:14:07";
            DateTime data = Convert.ToDateTime(dataString); // Converte a string "2024-07-01" para um DateTime
            Console.WriteLine(data); // Saída: 01/07/2024 00:00:00

            //Convertendo um inteiro em uma String 
            int numero = 456;
            string numstring = Convert.ToString(numero); // Converte o inteiro 456 para a string "456"
            Console.WriteLine(numstring); // Saída: 456
        }

    }
}