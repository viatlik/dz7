// Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы числа в двумерном массиве или же указание, что такого элемента нет.

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

int [, ] matrix = new int [5, 5];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

Console.WriteLine("Введите число: ");
int findNumber = int.Parse(Console.ReadLine());

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i,j] == findNumber)
        {
            Console.WriteLine("число в ячейке: " + i + "," + j);
        }
        else
        {
            Console.WriteLine("Ваше число отсутствует в массиве");
        }
    }
}
