// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
if (num==1)
{
    Console.Write("ПНД");
}
if (num==2)
{
    Console.Write("ВТ");
}
if (num==3)
{
    Console.Write("СР");
}
if (num==4)
{
    Console.Write("ЧТВ");
}
if (num==5)
{
    Console.Write("ПТН");
}
if (num==6)
{
    Console.Write("СБ");
}

if (num==7)
{
    Console.Write("ВС");
}
