Console.Clear(); //эта штука чистит консоль(терминал)
// Console.SetCursorPosition(10,4); //эта команда рисует с отступом 10 слева и 4 сверху
// Console.WriteLine("+"); //это чем будем рисовать

// int xa=1;
// int ya=1;
// int xb=1;
// int yb=30; // все это можно было написать через запятую в одну строчку, но в конце поставить точку с запятой, выглядело бы так int xa=1, ya=1, xb=1, yb=30;
// int xc=60;
// int yc=30;

int xa = 40, ya = 1,
xb = 1, yb = 30,
xc = 80, yc = 30;

Console.SetCursorPosition(xa,ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb,yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc,yc);
Console.WriteLine("+");

int x = xa, y = xb;
int count = 0;

while(count<1000)
{
    int what = new Random().Next(0,3); //[0;3) 0 1 2
    if(what==0)
    {
        x=(x+xa)/2;
        y=(y+ya)/2;
    }

    if (what==1)
    {
        x=(x+xb)/2;
        y=(y+yb)/2;
    }

    if (what==2)
    {
        x=(x+xc)/2;
        y=(y+yc)/2;
    }

    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count++; //тоже самое что и count=count+1 или count+=1
}
//Serpinsky's triangle