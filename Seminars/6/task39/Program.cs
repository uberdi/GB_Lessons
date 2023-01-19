//  Задача 39: Напишите программу,
//  которая перевернёт одномерный массив 
//  (последний элемент будет на первом месте, 
//  а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write($"{array[i]} ");
}
int[] arr = new int[10];
for (int i = 0; i < arr.Length; i++)
{
    arr[arr.Length - 1 - i] = array[i];
}
Console.WriteLine();
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} ");
}