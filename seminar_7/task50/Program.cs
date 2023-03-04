// Задача 50. Напишите программу, которая на вход принимает позиции элемента
//  в двумерном массиве, и возвращает значение этого элемента или же указание, 
//  что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> по данным индексам такого числа в массиве нет


int[,] GetArray()
{
    Console.Write("Сколько строк должно быть в массиве: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Сколько столбцов должно быть в массиве: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 101);
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

void ValueOfDoubleArrayElementByIndexes(int[,] array)
{
    Console.Write("Введите номер строки в которой находится элемент: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите номер столбца в котором находится элемент: ");
    int column = Convert.ToInt32(Console.ReadLine());

    if (rows > array.GetLength(0) - 1 || column > array.GetLength(1) - 1)
    {
        Console.WriteLine("По данным индексам нет числа в массиве!");
    }
    else
    {
        Console.WriteLine(array[rows, column]);
    }
}

int[,] mass = GetArray();
PrintArray(mass);
ValueOfDoubleArrayElementByIndexes(mass);