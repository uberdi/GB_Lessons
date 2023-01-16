// Задача 33: Задайте массив. 
// Напишите программу, которая определяет,
//  присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// int[] array = new int[6];
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-9, 10);
//     Console.WriteLine(array[i]);

// if ( array[i]==num)
// Console.WriteLine("Да");
// else Console.WriteLine("Нет");
// }

// ++Вариант с вводом ключа Х

int[] array = new int[6];
int x=0;
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write($"{array[i]} ");
}
for (int i = 0; i < array.Length; i++)
{
if ( array[i]==num)
{
x=1;
}
}
if (x==1)
{
   Console.WriteLine("Да"); 
}

else Console.WriteLine("Нет");
