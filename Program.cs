// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

int [,] ResMas (int [,] ar1, int [,] ar2)
{
    int [,] ResMas= new int [ar1.GetLength(0),ar2.GetLength(1)];
    for (int i = 0; i < ar1.GetLength(0); i++)
    {
        for (int j = 0; j < ar2.GetLength(1); j++)
        {
            for (int k=0; k<ar2.GetLength(0); k++)
            {
                ResMas[i,j]+= ar1[i,k]*ar2[k,j]; 
            }
        }
    }
    return ResMas;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}  ");

        }
        Console.WriteLine();
    }
}
int[,] array1= GetArray(2,2,0,10);
int[,] array2= GetArray(2,2,0,10);
int[,] array3=ResMas(array1,array2);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
PrintArray(array3);