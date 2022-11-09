// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int [,] array = Getarray (6,5,10,99);
PrintArray (array);
RowSort (array);
Console.WriteLine ("==========================");
PrintArray (array);

void RowSort(int[,] array)
{
    int m = array.GetLength(0); int n = array.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n-1; j++)
        {
            int maxPosition = j;
            for (int k = j + 1; k < n; k++)
            {
                if (array [i,k] > array[i,maxPosition]) maxPosition = k;
            }
            int temp = array [i,j];
            array [i,j] = array [i,maxPosition];
            array [i,maxPosition] = temp;
        }
    }
}

int[,] Getarray(int m, int n, int MinValue, int MaxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(MinValue, MaxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"|{Array[i, j]}| ");
        }
        Console.WriteLine();
    }
}
