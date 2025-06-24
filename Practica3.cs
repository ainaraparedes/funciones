/*using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

class Program
{
    static void Main ()
    {
        int pares = 0;
        int impares = 0;
        while (true)
        {
            Console.WriteLine("Ingrese un número (distinto de  cero): ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int numero))
            {
                if (numero == 0)
                {
                    Console.WriteLine($"Cantidad de números pares: {pares}");
                    Console.WriteLine($"Cantidad de números impares: {impares}");
                    break;
                }
                else if (numero % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }

            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
            
            
        }
    }
}
*/