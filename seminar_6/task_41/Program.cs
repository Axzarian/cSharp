// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] GetArray()
{
    Console.Write("Сколько чисел вы планируете ввести: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];

    for (int index = 0; index < size; index++)
    {
        Console.Write($"Введите {index + 1} элемент: ");
        array[index] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("Ваш массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}    ");
    }
}

int CountPositive(int[] ar)
{
    int count = 0;

    for (int ind = 0; ind < ar.Length; ind++)
    {
        if (ar[ind] > 0) count+=1;
    }
    return count;
}

int[] mass = GetArray();
Console.WriteLine();
PrintArray(mass);
Console.WriteLine();
Console.WriteLine($"Количество элементов больше нуля: {CountPositive(mass)}");