using System;

namespace MeuApp
{

    class Program
    {
        static void Main(string[] args)
        {
            float valor = 25.8f;
            int outro = 25;
            valor = outro; // Conversão implícita / implicit conversion, basicamente declaramos dois tipos e depois os associamos;
            Console.WriteLine(valor);
            

            // Conversão implícita só funciona se os tipos forem compatíveis, portanto abaixo tem uma tabela com as compatibilidades;

            // - sbyte 
            // - short, int, long, float, double, decimal

            // - byte
            // - short, ushort, int, uint, long, ulong, float, double, decimal
            
            // - short
            // - int, long, float, double, or decimal
            
            // - ushort
            // - int, uint, long, ulong, float, double, or decimal
            
            // - int
            // - long, float, double, or decimal |

            // - uint
            // - long, ulong, float, double, or decimal

            // - long
            // - float, double, or decimal

            // - ulong
            // ~ float, double, or decimal
            
            // - char |
            // - ushort, int, uint, long, ulong, float, double, or decimal

            // - float
            // - double |
        }

    }
}