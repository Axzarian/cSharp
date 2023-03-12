int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] GetArray()
{
    int rows = Prompt("Input number of rows you want: ");
    int cols = Prompt("Input number of columns you want: ");
    int[,] array = new int[rows, cols];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] SortEveryRow(int[,] massif)
{
    for (int i = 0; i < massif.GetLength(0); i++)
    {
        int sortedSize = 0;
        while (sortedSize < massif.GetLength(1) - 1)
        {
            for (int j = 0; j < massif.GetLength(1) - 1; j++)
            {
                int temp = 0;
                if (massif[i, j] < massif[i, j + 1])
                {
                    temp = massif[i, j];
                    massif[i, j] = massif[i, j + 1];
                    massif[i, j + 1] = temp;
                }
            }
            sortedSize += 1;
        }
    }
    return massif;
}

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой 
// строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void RowWithTheLowestSum(int[,] array)
{
    int indexOfMinString = 0;
    int sum = 0;
    int i = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    int minSum = sum;

    for (i = 1; i < array.GetLength(0); i++)
    {
        int sum1 = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum1 += array[i, j];
        }
        if (sum1 < minSum)
        {
            minSum = sum1;
            indexOfMinString = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Min value equales:{minSum}\nIt is in the {indexOfMinString} row");
}

// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void MultiplyMatrixes(int[,] array, int[,] massif)
{
    int[,] result = new int[array.GetLength(0), massif.GetLength(1)];

    if (array.GetLength(1) != massif.GetLength(0))
    {
        Console.WriteLine();
        Console.WriteLine("It is impossible to multiply these matrixes");
    }
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < massif.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    result[i, j] += array[i, k] * massif[k, j];
                }
            }
        }
        Console.WriteLine();
        PrintArray(result);
    }
}

void Task54()
{
    int[,] mass = GetArray();
    PrintArray(mass);
    int[,] newMass = SortEveryRow(mass);
    Console.WriteLine();
    PrintArray(newMass);
}
Task54();

void Task56()
{
    int[,] mass = GetArray();
    PrintArray(mass);
    RowWithTheLowestSum(mass);
}
// Task56();

void Task58()
{
    int[,] array = GetArray();
    int[,] massif = GetArray();
    PrintArray(array);
    Console.WriteLine();
    PrintArray(massif);
    MultiplyMatrixes(array, massif);

}
// Task58();



