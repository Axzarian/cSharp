// Нахождение суммы не главной диагонали для 
// квадратной матрицы.

//  0    0    0   (1)    Показал диагональ.
//  0    0   (1)   0
//  0   (1)   0    0
// (1)   0    0    0


int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}   ");
        }
        Console.WriteLine();
    }
}

void SumOfNotMainDiagonal(int[,] array)
{
    int result = 0;

    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i + j == array.GetLength(0) - 1)
                {
                    result = result + array[i, j];
                }
            }

        }
        Console.WriteLine();
        Console.WriteLine(result); 
    }
    else
    {
        Console.WriteLine("Данная матрица не квадратная!");
    }
}


int[,] mass = GetArray(4, 4);
PrintArray(mass);
Console.WriteLine();
SumOfNotMainDiagonal(mass);
