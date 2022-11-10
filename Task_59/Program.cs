// Задача 59: Отсортировать нечетные столбцы массива по возрастанию. Вывести массив изначальный и массив с отсортированными нечетными столбцами

int[,] array = Getarray(7, 9, 0, 9);
PrintArray(array);
OddColmnSort(array);
Console.WriteLine("_______________________________");
PrintArray(array);

void OddColmnSort(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int j = 1; j < n; j=j+2)
    {
        for (int i = 0; i < m-1; i++)
        {
            int minPosition = i;
            for (int k = i + 1; k < m; k++)
            {
                if (array [k,j] < array [minPosition,j]) minPosition = k;
            }
            int temp = array [i,j];
            array [i,j] = array [minPosition,j];
            array [minPosition,j] = temp;

        }
    }
    
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

