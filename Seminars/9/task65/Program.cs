﻿// Задача 65: 
// Задайте значения M и N.
//  Напишите программу, 
//  которая выведет 
//  все натуральные числа 
//  в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8

Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int Nat(int N)
{
if(N == M)
{
return M;
}
Console.Write(N);
return Nat(N - 1);
}
int x = Nat(N);
Console.WriteLine(x);