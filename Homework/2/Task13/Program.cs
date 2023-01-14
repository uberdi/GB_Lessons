// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// // 645 -> 5
// // 78 -> третьей цифры нет
// // 32679 -> 6

//правильное решение через остатки от деления и тд
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num<100)
{
    Console.WriteLine("У этого числа нет третьей цифры");
}
else if (num>99)
{
    while(num>999)
    {  
        num=num/10;
    }
    Console.Write("Третья цифра: ");
    Console.WriteLine(num%10);
}

//альтернативное решение через строки
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (-99>num)
// {   
//     string str = num.ToString();
// Console.WriteLine(str[3]);
// }
// else if (num>99)
// {   
//     string str = num.ToString();
// Console.WriteLine(str[2]);
// }
// else 
// {
//     Console.Write("третьей цифры нет");
// }