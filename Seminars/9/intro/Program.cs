// !5=1*2*3*4*5 факториал пяти

int Fact(int num)
{
    if (num==1)
    {
        return 1;
    }
    return num*Fact(num-1);
}

int x= Fact(5);
Console.WriteLine(x);

