using System;

namespace Exercicio_de_fixação
{
    class Program
    {
        static void Main(string[] args)
        {
int[] numeros = new int[15];

            for (var i = 0; i <= 14; i++) {
                
                Console.WriteLine();
                Console.WriteLine($"Digite o {i+1}° número:\n ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("--------------------------------");

            Console.WriteLine();

            Console.WriteLine("Sua lista com os números na ordem invertida em que digitou é:\n ");
            
            for (var i = 14; i >= 0; i--) {
                

                Console.WriteLine();

                Console.WriteLine(numeros[i]);

                

            }
            
            Console.WriteLine("--------------------------------");
        }
    }
}
