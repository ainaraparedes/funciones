/*using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>();

        while (true)
        {
            Console.WriteLine("Ingrese un número entero (distinto de cero): ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int entero))
            {
                if (entero == 0)
                {
                    break;
                }
                numeros.Add(entero);
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
            }
        }

        List<int> impares = new List<int>();
        foreach (int numero in numeros)
        {
            if (numero % 2 != 0)
            {
                impares.Add(numero);
            }
        }
        impares.Sort();
        impares.Reverse();

        foreach (int numero in impares)
        {
            Console.Write(numero + ", ");
        }
        Console.WriteLine();

    }
}
*/