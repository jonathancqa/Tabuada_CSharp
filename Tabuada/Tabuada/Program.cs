using System;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" === TABUADA DA MALLU ===");

            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());
            
            int calc, i = 0;

            for (i = 0; i <= 10; i++) {
                
                calc = num * i;
                Console.WriteLine($"{num} x {i} = {calc}");
            }
        }
    }
}
