// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] GetArray()
{
    Console.Write("How many rows do you want to have: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("How many columns do you want to have: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11);
        }
    }
    return array;
}

void PrintArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}\t");
        }
        Console.WriteLine();        
    }
    
}

void AvarageOfEachColumn(int [,] massif)
{
    double sum = 0;
    double avarage = 0;
    for (int j = 0; j < massif.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < massif.GetLength(0); i++)
        {
            sum += massif [i,j];                    
        }
        avarage = Math.Round(sum / (massif.GetLength(1)),1);
        Console.Write($"{avarage}\t");        
    }
}

int [,] mass = GetArray();
PrintArray(mass);
Console.WriteLine();
AvarageOfEachColumn(mass);