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

            Console.Write("");
            string num2 = Console.ReadLine();
            int y = Convert.ToInt32(num2);

            if( x == y){
                Console.WriteLine("São iguais");
                Console.WriteLine(x);
                Console.WriteLine(y);
            }
            else if( x > y){
                Console.WriteLine("x é maior que y");
                Console.WriteLine(x);
            }
            else{
                Console.WriteLine("Y é maior que x");
                Console.WriteLine(y);
            }
            


        }

    }
}