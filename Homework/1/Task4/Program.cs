﻿// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число 1 ");
    int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2 ");
    int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3 ");
    int numC = Convert.ToInt32(Console.ReadLine());

int max = numA;
    
if (max<numB) max=numB;
if (max<numC) max=numC;
   
        Console.Write("max = ");
        Console.Write(max); 
    