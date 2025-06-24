/*using System;
using System.Collections.Generic;
using System.Linq;

int[] num = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Ingrese un número: ");
    num[i] = int.Parse(Console.ReadLine());
}

int positive = 0;
int negative = 0;
int zero = 0;

foreach (int valor in num)
{
    if (valor == 0)
    {
        zero++;
    }
    else if (valor > 0)
    {
        positive++;
    }
    else
    {
        negative++;
    }
}
Console.WriteLine("Cantidad de números cero: " + zero);
Console.WriteLine("Cantidad de números negativos: " + negative);
Console.WriteLine("Cantidad de números positivos: " + positive);
*/