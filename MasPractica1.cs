/*using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> calificaciones = new List<int>();
        while (true)
        {

            Console.WriteLine("Ingrese cantidad de usuarios que ingresaran una calificación: ");
            string usuarios = Console.ReadLine();

            if (int.TryParse(usuarios, out int numUsuarios))
            {

                for (int i = 0; i < numUsuarios; i++)
                {
                    Console.WriteLine("Ingrese una calificación a los servicios (1 a 5): ");
                    string entrada = Console.ReadLine();

                    if (int.TryParse(entrada, out int calificacion) && calificacion > 0 && calificacion <= 5)
                    {
                        calificaciones.Add(calificacion);
                    }
                    else
                    {
                        Console.WriteLine("Calificación inválida.");
                        i--;
                    }
                }
                break;
            }
            else
            {
                Console.WriteLine("Cantidad de usuarios inválida");
            }

        }

        int TotalCalificaciones = calificaciones.Count();

        for (int i = 1; i <= 5 ; i++)
        {
            int contador = calificaciones.Count(x => x == i);
            double porcentaje = (double)contador / TotalCalificaciones * 100;
            Console.WriteLine($"Número: {i}, aparece {contador} veces, y su porcentaje es {porcentaje}%");

        }
    }
}
*/

