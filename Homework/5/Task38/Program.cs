// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным
//   и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int []array=new int[6];

for (int i=0; i<array.Length; i++)
    {
    array[i] = new Random().Next(1,20);
     Console.Write($"{array[i]} ");
    }
int max = array[0];
int min = array[0];
for (int i=0; i<array.Length; i++)
    {
    if (array[i]>max) max=array[i];
    if (array[i]<min) min=array[i];
    } 
Console.WriteLine();
Console.Write("Максимальное число " + max + " Минимальное число "+min);
Console.WriteLine();
Console.Write(max - min);