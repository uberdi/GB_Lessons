// Задача 41: 
// Пользователь вводит 
// с клавиатуры M чисел.
// Посчитайте, 
// сколько чисел 
// больше 0 ввёл пользователь.

//  0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

 Console.Write("Кол-во чисел: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    int[] array = new int[m];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Число " + Convert.ToString(i + 1) + " ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0) count++;
    }
    Console.WriteLine("Кол-во чисел > 0: " + count);