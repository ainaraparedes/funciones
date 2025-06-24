/*
using System;
using System.Collections.Generic;
using System.Linq;

int[,] matriz =
{
    {1, 2, 3 },
    {4, 5, 100 },
    {7, 8, 9 }
};
int mayorSuma = int.MinValue;
int mayorFila = 0;

for (int row = 0; row < matriz.GetLength(0); row++)
{
    int suma = 0;
    for (int col = 0; col < matriz.GetLength(1); col++)
    {
        suma += matriz[row, col];
    }
    if (suma > mayorSuma)
    {
        mayorSuma = suma;
        mayorFila = row;
    }
}

for (int col = 0; col < matriz.GetLength(1); col++)
{
    Console.Write(matriz[mayorFila, col] + ", ");

}
Console.WriteLine();
*/