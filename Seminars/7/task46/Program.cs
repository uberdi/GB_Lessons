﻿// // Задача 46:
// Задайте двумерный массив 
// размером m×n, 
// заполненный случайными 
// целыми числами.
// // m = 3, n = 4.
// // 1 4 8 19
// // 5 -2 33 -2
// // 77 3 8 1

Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,]array=new int[m,n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j]=new Random().Next(0,100);
        Console.Write ($"{array[i,j]} ");
    }
    Console.WriteLine ();
}

// Console.WriteLine("Введите число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i, j] = new Random().Next(0, 100);

// Console.Write($"{array[i, j]} ");

// }
// Console.WriteLine();
// }