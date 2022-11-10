// Задача 58: Задайте две квадратные матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] First2Darr = Getarray(2, 2, 1, 5);
int[,] Second2Darr = Getarray(2, 2, 1, 5);
PrintArray(First2Darr);
Console.WriteLine("================");
PrintArray(Second2Darr);
int[,] Resultarr = MatrixProduct(First2Darr, Second2Darr);
Console.WriteLine("====================");
PrintArray(Resultarr);

int[,] MatrixProduct(int[,] arr1, int[,] arr2)
{
    int m = arr1.GetLength(0); int n = arr1.GetLength(1);
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int sum = 0;
            for (int k = 0; k < n; k++)
            {
                 sum = arr1[i, k] * arr2[k, j];
                 result[i, j] += sum;
            }
        }
    }
    return result;
}

int[,] Getarray(int m, int n, int MinValue, int MaxValue)
{
    int[,] result = new int[m, n];
    for (int j = 0; j < n; j++)
    {
        for (int i = 0; i < m; i++)
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
