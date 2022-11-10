// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] Array2D = Fillarray(4, 4);
PrintArray(Array2D);

int[,] Fillarray(int m, int n)
{
    int[,] result = new int[m, n];
    int c = 1;
    for (int j = 0; j < m; j++) // Заполняем периметр массива по порядку
    {
        result[0, j] = c;
        c++;
    }
    for (int i = 1; i < n; i++)
    {
        result[i, n - 1] = c;
        c++;
    }
    for (int j = n - 2; j >= 0; j--)
    {
        result[m - 1, j] = c;
        c++;
    }
    for (int i = m - 2; i >= 1; i--)
    {
        result[i, 0] = c;
        c++;
    }
    PutInside(1, 1); // Заполняем массив внутри через рекурсию
    void PutInside(int i, int j)
    {
        if (result[i, j] == 0)
        {
            result[i, j] = c;
            c++;
            PutInside(i, j + 1);
            PutInside(i + 1, j);
            PutInside(i, j - 1);
            PutInside(i - 1, j);
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
            Console.Write($" {Array[i, j]}  ");
        }
        Console.WriteLine();
    }
}