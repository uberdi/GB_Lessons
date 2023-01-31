// // Задача 53: Задайте двумерный массив. 
// // Напишите программу, 
// // которая поменяет местами 
// // первую и последнюю строку массива.

// Console.WriteLine("Введи кол-во строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введи кол-во столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,]array=new int[m,n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//  for (int j = 0; j < array.GetLength(1); j++)
//  {
//     array[i,j]=new Random().Next(0,10);
//     Console.Write($"{array[i,j]} ");
//  }   
//  Console.WriteLine();
// }
// for (int j = 0; j < array.GetLength(1); j++)
// {
//     int temp = array[0,j];
//     array[0,j]=array[array.GetLength(1)-1,j];
//     array[array.GetLength(1)-1, j]=temp;
// }
// Console.Write

Console.WriteLine("Введите размер массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(0, 10);
Console.Write($"{matrix[i, j]} ");
}
Console.WriteLine();
}
Console.WriteLine();
int[,] mat = new int[m, n];
for (int i = 0; i < mat.GetLength(0); i++)
{
for (int j = 0; j < mat.GetLength(1); j++)
{if(i==0) mat[i, j] = matrix[m-1,j];
else if (i==(m-1)) mat[i, j] = matrix[0,j];
else mat[i, j] = matrix[i,j];
Console.Write($"{mat[i, j]} ");
}
Console.WriteLine();
}