// Задача 32: Напишите программу замена элементов массива:
//  положительные элементы замените
//   на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array = new int[12];//создаем массив из 12 нулей

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);//нули в массиве заменяем на цифры от -9 до 9
    Console.Write($"{array[i]} ");
}

Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    array[i] = -1 * array[i];
    Console.Write(array[i]);
}

//какое то альтернативное решение (вообще ниче не понял)
// int[] array = { -7, -4, 3, 4};
// void PrintArray(int[]array)
// {
// int count = array.Length;

// for (int index = 0; index < count; index++)
// {
// Console.Write($"{array[index]} ");

// }

// }
// int[] SArray(int[] array1)
// {
// for (int index = 0; index < array.Length; index++)
// {
// array1[index]*=(-1);

// }
// return array1;
// }

// PrintArray(array);
// int [] array2 = SArray(array);
// Console.WriteLine();
// PrintArray(array2);