﻿// Задача 28: Напишите программу, 
// которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 1;
for(int i=1;i<=num; i++)
{
   sum=sum*i;
}
Console.WriteLine(sum);