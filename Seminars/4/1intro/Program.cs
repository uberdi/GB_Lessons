void SayHello(string lang)
{
Console.WriteLine($"Привет, {lang}");
}

Console.WriteLine();
Console.WriteLine();

SayHello("c#");

Console.WriteLine();
Console.WriteLine();
string name = "c++";
SayHello(name);