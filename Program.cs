using Cleverence.Task2;
using System;

int[,] matrix1 = {
    { 1, 2, 3, 4 },
    { 5, 6, 7, 8},
    { 9, 10, 11, 12}
};

int[,] matrix2 = {
    { 1, 2, 3},
    { 4, 5, 6 },
    { 7, 8, 9 }
};




int[] result1 = SpiralMatrixCompute.ReverseSpiralOrder(matrix1);

foreach (int num in result1)
{
    Console.Write(num + " ");
}
// Выведет: 1 5 9 10 11 12 8 4 3 2 6 7
Console.WriteLine();
int[] result2 = SpiralMatrixCompute.ReverseSpiralOrder(matrix2);

foreach (int num in result2)
{
    Console.Write(num + " ");
}
// Выведет: 1 4 7 8 9 6 3 2 5

