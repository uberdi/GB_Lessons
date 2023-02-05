// Задача 67: 
// Напишите программу, 
// которая будет 
// принимать на вход число 
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int Nat(int num)
{
if(num % 10 == 0)
{
return 0;
}

return (num % 10 + Nat(num / 10));
}
int x = Nat(num);
Console.WriteLine(x);