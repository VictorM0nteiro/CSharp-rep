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
            string name = Console.ReadLine();

            switch (x)
            {
                case 1: 
                    Console.WriteLine("You Chose 1");
                    break;
                case 2: 
                    Console.WriteLine("You chose 2");
                    break;
                case 3: 
                    Console.WriteLine("You chose 3");
                    break;
                default: 
                    Console.WriteLine("You've chosen another number");
                    break;
            }

            switch (name)
            {
                case "joao": Console.WriteLine("That ain't the right name");
                    break;
                case "Charles": Console.WriteLine("That ain't the right name");
                    break;
                case "victor": Console.WriteLine("That is the right name");
                    break;
                default: Console.WriteLine("Seriouly? :(");
                    break;
            }


        }

    }
}