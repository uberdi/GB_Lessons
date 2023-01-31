// Задача 47. 
// Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array=new double[m,n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j]=new Random().NextDouble();
        Console.Write ($"{array[i,j]} ");
    }
    Console.WriteLine ();
}
//числа которые у меня получаются это просто дроби от 0 до 1(например 0,2947162341402333), так и не понял как сделать числа например 5.5, 7.8 и т.д.