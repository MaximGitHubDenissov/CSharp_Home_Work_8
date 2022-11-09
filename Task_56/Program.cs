// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

int[,] arr2D = Getarray(4, 5, 0, 9);
PrintArray(arr2D);
RowSumm(arr2D);

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

void RowSumm(int[,] array)
{
    int m = array.GetLength(0); int n = array.GetLength(1);
    int[] arr = new int[m];
    for (int i = 0; i < m; i++)
    {
        int sum = 0;
        for (int j = 0; j < n; j++)
        {
            sum = sum + array[i, j];
        }
        arr[i] = sum;
    }
    Console.WriteLine(String.Join(",", arr)); //Выводим для тестирования 
    int minIndex = 0; int min = arr[0];
    for (int k = 0; k < arr.Length; k++)
    {
        if (arr[k] < min)
        {
            min = arr[k];
            minIndex = k;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов на {minIndex + 1} строке");
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
