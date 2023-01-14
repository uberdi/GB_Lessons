// // Задача 19
// // Напишите программу, которая принимает на 
// вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да

Console.Write("Введите пятизначное число: ");
int num =Convert.ToInt32(Console.ReadLine()); //int num = int.Parse(Console.ReadLine());
int a1 = num / 10000;
int a2 = num / 1000 % 10;
int a3 = num / 100 % 10;
int b1 = num % 10;
int b2 = num % 100 / 10;
int b3 = num % 1000 / 100;
if (a1 == b1 && a2 == b2 && a3 == b3)
    {
        Console.WriteLine("да, палиндром");
    }
else
    Console.WriteLine("не палиндром");