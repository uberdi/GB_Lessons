// // Задача №17. Напишите программу, 
// которая принимает на вход координаты точки (X и Y),
// // причем X ≠ 0 и Y ≠ 0 и 
// выдаёт номер четверти плоскости, в которой находится эта точка.
Console.WriteLine("Введите x");
int x =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y");
int y =Convert.ToInt32(Console.ReadLine());
if (x>0 && y>0)
Console.WriteLine("Первая четверть");
else if (x<0 && y>0)
Console.WriteLine("вторая четверть");
else if (x<0 && y<0)
Console.WriteLine("третья четверть");
else if (x>0 && y<0)
Console.WriteLine("четвертая четверть");