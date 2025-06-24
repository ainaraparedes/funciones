/*using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Ingrese tamaño de arreglo: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int tamano))
            {
                double [] numeros = new double[tamano];

                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.WriteLine("Ingrese un número al arreglo: ");
                    string lectura = Console.ReadLine();

                    if (double.TryParse(lectura, out double valido))
                    {
                        numeros[i] = valido;
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida.");
                        i--;
                    }
                }
                 
                double sumatoria = 0;
                for (int i = 0; i < numeros.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        sumatoria += numeros[i];
                    }
                    else
                    {
                        sumatoria -= (3 * numeros[i] - 1);
                    }

                }
                Console.WriteLine(sumatoria);
                break;
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }

            
            
        }
    }
}
*/