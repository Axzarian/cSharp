/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] CreateArray()
{
    Console.Write("Массив какого размера вы хотите получить: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];

    for (int index = 0; index < size; index++)
    {
        array[index] = new Random().Next(-10, 11);   //исп маленькие значения дабы вам было легче проверять.
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("Массив вашему вниманию: ");
    foreach (int element in arr)
    {
        Console.Write(element + " ");
    }
}


/*Была мысль сделать два метода
 Первый создает массив из нечетных
 элементов принимаемого массива.
 А второй метод складывает все значения 
 элементов в массиве :) */
int OddPositionElementsSum(int[] massif)
{
    int sum = 0;
    for (int i = 1; i < massif.Length; i += 2)
    {
        sum += massif[i];
    }
    return sum;
}



int[] mass = CreateArray();
PrintArray(mass);
int x = OddPositionElementsSum(mass);
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных позициях: {x}");
