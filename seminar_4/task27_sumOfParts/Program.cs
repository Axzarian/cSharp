// Задача 27: Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumOfElements(int num)
{
    int result = 0;
    int temp = Math.Abs(num); //Чтобы находить сумму элементов у отрицательных чисел

    while (temp>0)
    {
        result = result + (temp % 10);
        temp = temp / 10; //Пытался указать это в цикле for  не получилось
    }
    return result;
}

Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Summ of all number elements is: {SumOfElements(number)}");