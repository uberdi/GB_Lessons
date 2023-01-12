Console.Write ("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num>7)
{
    Console.WriteLine(num*num);
}
else
{
    Console.Write(num%2); //остаток от деления на два
}