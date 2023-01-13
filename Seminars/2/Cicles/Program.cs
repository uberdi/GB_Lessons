// цикл фор for 
double num1 = 2;
for (int i = 1; i < 7; i++)
{
    Console.WriteLine(i);
    if (i == 3) break; // брейк останавливает цикл, есть еще continue это наоборот продолжить с какого то места
}
Console.WriteLine("OK");

//цикл вайл
while (num1 < 7)
{
    Console.WriteLine(num1);
    num1 += 2;
}