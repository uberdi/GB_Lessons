// Найти макс из 9 чисел(дубль2)

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result =arg2;
    if (arg3>result) result =arg3;
    return result;
}

int a1 =1;
int b1 =2;
int c1 =3;
int a2 =6664;
int b2 =5;
int c2 =99;
int a3=11;
int b3=113;
int c3=43;

// int max1 = Max(a1,b1,c1);
// int max2 = Max(a2,b2,c2);
// int max3 = Max(a3,b3,c3);
// int max = Max(max1,max2,max3); можно написать так или способом ниже

int max =Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3));

Console.WriteLine(max);