int numberA = new Random().Next(1,10); // будет набор чисел 1,2,3...9 - десяти не будет тк всегда max-1
Console.WriteLine(numberA); //если не написать эту строку, то я не буду знать какое число взял рандомайзер
int numberB = new Random().Next(1,10);
Console.WriteLine(numberB);
int result = numberA+numberB;
Console.WriteLine(result);