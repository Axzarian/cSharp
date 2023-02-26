/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

double[] CreateArray()
{
    Console.Write("Укажите желаемую длинну массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[size];

    for (int index = 0; index < size; index++)
    {
        // array[index] = new Random().NextDouble() * 20 - 10;
        array[index] = new Random().Next(-100, 100);
    }
    return array;
}

void PrintArray(double[] arr)
{
    Console.Write("Массивчик подоспел: ");
    foreach (double element in arr)
    {
        Console.Write(element + " ");
    }
}

void MinMaxDiff(double[] massif)
{
    double min = massif[0];
    double max = massif[0];

    foreach (double el in massif)
    {
        if (el > max)
        {
            max = el;
        }
        else if (el < min)
        {
            min = el;
        }
    }    
    Console.WriteLine($"Разница между max и min элементами массива равна: {max - min}");

}

double[] mass = CreateArray();
PrintArray(mass);
Console.WriteLine();
MinMaxDiff(mass);

