// Задача 23

// Напишите программу, 
// которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[N];
for (int index = 0; index < N; index++)
{
    nums[index] = (index+1) * (index+1)*(index+1);
Console.WriteLine(nums[index]);
}

// или
// Console.WriteLine("Введите число ");
// int N = Convert.ToInt32(Console.ReadLine());
// for (int index = 1; index <= N; index++)
// {
//     Console.WriteLine(Math.Pow(index, 3));
// }