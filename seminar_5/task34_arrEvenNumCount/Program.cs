/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] CreateArray()
{
    Console.Write("Введите желаемый размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];

    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] arra)
{
    Console.Write("Ваш массив: ");
    for (int ind = 0; ind < arra.Length; ind++)
    {
        Console.Write(arra[ind] + " ");
    }

}

void CountEvenNumbers(int[] massif)
{
    int count = 0;
    for (int i = 0; i < massif.Length; i++)
    {
        if (massif[i] % 2 == 0)
        {
            count += 1;
        }
    }
    Console.WriteLine($"Количество четных элементов в массиве равно: {count}");
}

int[] mass = CreateArray();
PrintArray(mass);
Console.WriteLine();
CountEvenNumbers(mass);
