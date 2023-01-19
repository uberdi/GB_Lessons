// int[]num1= //одномерный
// int [,]= //двумерный
// int [,,]= //трехмерный
// int[,] num3=new int [2,3];

int[,] num2={{1,2,3},{4,5,5}}; // массив массивов
for (int i = 0; i < num2.GetLength(0); i++)
    for (int j = 0; j < num2.GetLength(1); j++)
    {
        Console.Write($"{num2[i,j]} ");
    }