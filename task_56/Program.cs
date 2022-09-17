﻿// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int rows = new Random().Next(3,7);
int columns = new Random().Next(3,7);
int[,] matrix = new int[rows, columns];
int sum = int.MaxValue;
int index = 0;

if (rows != columns)
{            
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(10);
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) temp += matrix[i, j];
        if (temp < sum)
        {
            sum = temp;
            index = i;
        }
    }
    Console.WriteLine("Строка: "+ (index + 1) +" Сумма - "+sum);
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(1); i++) Console.Write(matrix[index, i]+" ");
}
else
{
Console.Write("Массив не прямоугольный");
}