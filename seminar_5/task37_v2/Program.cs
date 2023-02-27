// Задача 37: Найдите произведение пар чисел в одномерном массиве.
//  Парой считаем первый и последний элемент, второй и предпоследний 
//  и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetArray()
{
    Console.Write("Массив какой длины вам создать: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 11);
    }
    return array;
}

void PrintArray(int[] massif)
{
    Console.Write("Ваш массив готов: ");
    for (int ind = 0; ind < massif.Length; ind++)
    {
        Console.Write(massif[ind] + " ");
    }
}

int[] MultElements(int[] arr)
{

    int index = 0;
    int len = arr.Length - 1;

    if (arr.Length % 2 != 0)
    {
        int[] result = new int[arr.Length / 2 + 1];

        while (index < len)
        {
            result[index] = arr[index] * arr[len];
            index++;
            len--;

            if (index == len)
            {
                result[index] = arr[index];
            }
        }
        return result;
    }
    else
    {
        int[] result = new int[arr.Length / 2];

        while (index < len)
        {
            result[index] = arr[index] * arr[len];
            index++;
            len--;
        }
        return result;
    }
}

int[] mass = GetArray();
PrintArray(mass);
Console.WriteLine();
int[] res = MultElements(mass);
PrintArray(res);
