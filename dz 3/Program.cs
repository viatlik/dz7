﻿// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

void PrintArray (int[, ]matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray (int[, ]matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,100);
        }
    }
}

int [, ] matrix = new int [3, 3];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);


for (int i = 0; i < matrix.GetLength(1); i++)
{
    int average = 0;

    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        average = average + matrix [j,i];
    }
    Console.WriteLine($" Среднее арифметическое элементов {i+1} = {((float)average / matrix.GetLength(0))}");
}
