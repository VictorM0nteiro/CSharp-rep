using System;

namespace MeuApp
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("");
            string num = Console.ReadLine();
            int x = Convert.ToInt32(num);

            int i = 0;
            while( i <= x){
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine(" ");

            //Conta de 0 a 5
            var j = 0;
            while( j <= 5){
                Console.WriteLine(j);
                j++;
            }
            Console.WriteLine(" ");

            //Conta de 1 a 5
            var a = 1;
            while(a <= 5){
                Console.WriteLine(a);
                a++;
            }
            Console.WriteLine(" ");

            //Conta de 0 a 4
            var n = 0;
            while(n < 5){
                Console.WriteLine(n);
                n++;
            }
            Console.WriteLine(" ");

            //Conta de 5 a 0
            var q = 5;
            while(q >= 0){
                Console.WriteLine(q);
                q--;
            }

            //INcrementando antes 1 a 6
            var w = 0;
            while(w <= 5){
                w++;
                Console.WriteLine(w);
            }

            // //infinito 
            // var valor = 0;
            // while(true){ // Infinito pois true nunca sera false
            //     valor++;
            //     Console.WriteLine(valor);
            // }
        }

    }
}