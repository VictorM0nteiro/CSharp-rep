using System;

namespace MeuApp
{

    class Program
    {
        static void Main(string[] args)
        {
             int x = 2;
             x = 2+2/2;
            Console.WriteLine(x);
            
            int y = 75/23;
            Console.WriteLine(y); // Como é um inteiro o resultado será arredondado;

            double z = 75/23.0; // importante esse ), pq se não a conta é tratada como int
            Console.WriteLine(z); // Não erredondaria porque é real
            


            int d = 2;
            d += 3; // Somando o valor d com 3; aldo assim d+3 não funcionaria, somente dentro de outra variável
            Console.WriteLine(d); 

            int r = 2;
            r -= 3;
            Console.WriteLine(r);

            int p = 7;
            p++; // Incrementa o Valor em 1; Seria o contrário se fosse p--;
            Console.WriteLine(p);



            //Comparções
            int c = 2;
            Console.WriteLine(x == 25); // bool int.operator ==(int left, int right), o resultado disso sera um booleano que no caso é falso

            int t = 25;
            Console.WriteLine(t <= 100); // resulta em um bool true

            int m = 2; 
            Console.WriteLine(m != 25);
        }

    }
}