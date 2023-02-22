// Задача 29: Напишите программу, которая задаёт массив из 
// 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write($"Input value of {index + 1} element: ");
        array[index] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for (int index = 0; index < arr.Length; index++)
    {
        Console.Write(arr[index] + " ");
    }  
    Console.WriteLine("]");
}

Console.Write("Input array's length: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[len];

FillArray(mass);
Console.WriteLine();
PrintArray(mass);  
