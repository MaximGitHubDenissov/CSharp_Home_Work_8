// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.WriteLine("Введите количество строк в 3D массиве");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов в 3D массиве");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество уровней в 3D массиве");
int k = int.Parse(Console.ReadLine()!);

int [] SingleArray = UniqArray (m,n,k,10,99);// Для проверки уникальности можно поставить minValue = 0, maxValue = 7 (если размер 3D массива 2х2х2);
int[,,] Array3D = GetarrayUniqNum(m, n, k, SingleArray);
Console.WriteLine(String.Join("  ", SingleArray));// Выводит уникальный одномерный массив (для проверки)
Console.WriteLine ("========================");
PrintArray(Array3D);

int[] UniqArray(int m, int n, int k, int minValue, int MaxValue)// Метод создает уникальные (неповторяющиеся) элементы в одномерном массиве
{

    int[] result = new int[m * n * k];
    bool AlreadyExist;
    for (int i = 0; i < result.Length;)
    {
        AlreadyExist = false;
        int num = new Random().Next(minValue, MaxValue + 1);
        for (int j = 0; j < i; j++)
        {
            if (result[j] == num)
            {
                AlreadyExist = true;
                break;
            }
        }
        if (!AlreadyExist)
        {
            result[i] = num;
            i++;
        }
    }
    return result;
}

int[,,] GetarrayUniqNum(int m, int n, int k, int[] collection)// Метод заполняет элементы 3D массива уникальными (неповторяющимися) элементами одномерного массива
{
    int[,,] result = new int[m, n, k];
    int c = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int z = 0; z < k; z++)
            {
                result[i, j, z] = collection[c];
                c++;
            }

        }
    }
    return result;
}

void PrintArray(int[,,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int z = 0; z < Array.GetLength(2); z++)
            {
                Console.WriteLine($"{Array[i, j, z]} ({i},{j},{z})");
            }
        }

    }
}


