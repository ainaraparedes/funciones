/*using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {

        while (true)
        {
            Console.WriteLine("Ingrese tamaño del arreglo: ");
            string entrada = Console.ReadLine();
            int tamano;

            if (int.TryParse(entrada, out tamano))
            {
                int[] arreglo1 = new int[tamano];
                for (int i = 0; i < arreglo1.Length; i++)
                {
                    Console.WriteLine($"Ingrese un valor para la posicion {i} del arreglo: ");
                    string ingreso = Console.ReadLine();
                    int numValido;

                    if (int.TryParse(ingreso, out numValido))
                    {
                        arreglo1[i] = numValido;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida.");
                    }
                }
                int suma = 0;
                for (int i = 0; i < arreglo1.Length; i++)
                {
                    suma += arreglo1[i];
                }
                double promedio = suma / arreglo1.Length;
                Console.WriteLine($"El promedio de los numeros ingresados en el arreglo es: {promedio}.");
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

