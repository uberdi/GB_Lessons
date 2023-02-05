// Задача 63: 
// Задайте значение N. 
// Напишите программу, 
// которая выведет все 
// натуральные числа 
// в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int Nat(int num)
{
if(num == 1)
{
return 1;
}
Console.Write(num);
return Nat(num - 1);
}
int x = Nat(num);
Console.WriteLine(x);