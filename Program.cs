using System;   

namespace MeuApp
{

    class Program
    {
        static void Main(string[] args)
        {

            var mouse = new Product(1, "Mouse Gamer", 299.97, /*5.13,*/  EProductType.Product); // aqui que foi definido que o nome MOUSE seria utilizado, também definindo o mouse como um PRODUCT

            var manutencaoEletrica = new Product(2, "Manutenção elétrica residencial", 500, EProductType.Service );
  
            mouse.Id = 5;
            //mouse.Name = "Mouse de escritório";
            //mouse.Price = 30.56;

            Console.WriteLine("Id: " + mouse.Id);
            Console.WriteLine("Name: " + mouse.Name);
            Console.WriteLine("Price: " + mouse.Price);
            Console.WriteLine("Type: " + mouse.Type);
            Console.WriteLine("Type Num: " + (int)mouse.Type);
             //Console.WriteLine("Dolar: " + mouse.Dolar);
            // double PriceInDolar = mouse.PriceInDolar(mouse.Dolar);
            // Console.WriteLine("Price in Dolar: " + PriceInDolar);

            Console.WriteLine(" ");

            Console.WriteLine("Id: " + manutencaoEletrica.Id);
            Console.WriteLine("Name: " + manutencaoEletrica.Name);
            Console.WriteLine("Price: " + manutencaoEletrica.Price);
            Console.WriteLine("Type: " + manutencaoEletrica.Type);
            Console.WriteLine("Type Num: " + (int)manutencaoEletrica.Type);
        }
    }

    struct Product
    {
        public Product(int id /*propriedades*/, string name, double price, /*double dolar ,*/ EProductType type) // Método CONSTRUTOR é necessário explicitar as propriedades!!!!!!!
        {
            // letra minusculo é um parâmetro
            Id = id;
            Name = name; // Propriedade = parâmetro
            Price = price; 
            //Dolar = dolar;// Propriedade = parâmetro
            Type = type;
        }

        public int Id;
        public string Name;
        public double Price; // letra maiuscula é uma propriedade
        //public double Dolar;
        public EProductType Type; // Propriedade feita a partir do enum;;;  Propriedade : EProductType     Nome da Propriedade : Type;

        public double PriceInDolar( double dolar){
            return Price * dolar; // letra minuscula é um parâmetro
        }
    }

    enum EProductType{
        Product = 1, // Utilizar a "  ,   "
        Service = 2,
    }
}
