/*using System;
using System.Collections.Generic;
using System.Linq;

List <int> nums = new List<int>();

while (true)
{
    Console.WriteLine("Ingrese un numero (distinto de cero): ");
    string n = Console.ReadLine();

    
    if (int.TryParse(n, out int number))
    {
        if (number == 0)
        {
            break;
        }
        nums.Add(number);

    }
    else
    {
        Console.WriteLine("Ingrese un número correcto");
    }
        
}

List<int> pares = new List<int>();
foreach (int i in nums)
{
    
    if (i % 2 != 0)
    {
        pares.Add(i);
    }
}
pares.Sort();
pares.Reverse();
Console.WriteLine(string.Join(", ", pares));
*/

/*using System.ComponentModel.Design;
using System.Globalization;

Console.WriteLine("Ingrese tamaño del arreglo: ");
string tamano = Console.ReadLine();
while (true)
{
   if (int.TryParse(tamano, out int nums))
    {
        if (nums == 0)
        { break; }
        int[] numeros = new int[nums];
    }
    else
    {
        Console.WriteLine("Ingrese un tamaño de arreglo valido");
    }
    
}
*/

/*List<int> numeros = new List<int> { 1, 9, 3, 5 };

numeros.Sort();
numeros.Reverse();
foreach (int numero in numeros)
{
    Console.Write(numero + ", ");
   
}
Console.WriteLine();
*/