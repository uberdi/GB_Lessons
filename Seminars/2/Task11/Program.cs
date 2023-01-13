// 11) Напишите программу, которая 
// выводит случайное трехзначное число 
// и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int result1 = num%10;
int result2=(num/10)%10;
int result3=num/100;

Console.WriteLine($"{result3}{result1}");
