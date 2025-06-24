/*using System;
using System.Collections.Generic;
using System.Linq;

Random nums = new Random(10);
List<int> numeros = new List<int>();

for (int i = 0; i < 10; i++)
{
    int aleatorios = nums.Next(1, 100);
    numeros.Add(aleatorios);
}
foreach (int i in numeros)
{
    Console.WriteLine(i);
}
//para comprobar que se estan almacenando correctamente los numeros.

Console.WriteLine("Ingrese un valor límite: ");
int valorLimite = int.Parse(Console.ReadLine());

var listaFinal = numeros.Where(n => n > valorLimite);

Console.WriteLine("La lista final es: ");
foreach (int i in listaFinal)
{
    Console.WriteLine(i);
}
*/