// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double [,] GetArray()
{
    Console.Write("Введите желаемое количсетво строк: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите желаемое количсетво столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().Next(-10,100) + new Random().NextDouble(),1);
        }
    }
    return array;
}

void PrintArray(double[,] arr)
{
    Console.WriteLine("Ваш массив, господин: ");
    Console.WriteLine("----------------------");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}          ");
        }
        Console.WriteLine();
    }
}

double[,] mass = GetArray();
Console.WriteLine();
PrintArray(mass);