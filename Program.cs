using System;   

namespace MeuApp
{

    class Program
    {
        static void Main(string[] args)
        {

            var mouse = new Product(1, "Mouse Gamer", 299.97, 5.13);

            mouse.Id = 5;
            //mouse.Name = "Mouse de escritório";
            //mouse.Price = 30.56;

            Console.WriteLine("Id: " + mouse.Id);
            Console.WriteLine("Name: " + mouse.Name);
            Console.WriteLine("Price: " + mouse.Price);
            Console.WriteLine("Dolar: " + mouse.Dolar);
            

            double PriceInDolar = mouse.PriceInDolar(mouse.Dolar);
            Console.WriteLine("Price in Dolar: " + PriceInDolar);

        }
    }

    struct Product
    {
        public Product(int id /*propriedades*/, string name, double price, double dolar) // Método CONSTRUTOR é necessário explicitar as propriedades!!!!!!!
        {
            Id = id;
            Name = name; // atribuindo os parâmetros às propriedades
            Price = price; // propriedades recebendo parâmetros
            Dolar = dolar;
        }

        public int Id;
        public string Name; // parâmetros
        public double Price; // letra maiuscula é uma propriedade
        public double Dolar;

        public double PriceInDolar( double dolar){
            return Price * dolar; // letra minuscula é um parâmetro
        }
    }
}