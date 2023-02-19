int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return number;
}

int ReverseNumber(int a)
{
    int revNum = 0;
    int temp = a;
    while (temp > 0)
    {
        revNum = revNum * 10 + temp % 10;
        temp /= 10;

    }
    return revNum;
}

int a = Prompt("Введите 5-и значное число: ");
int reversed = ReverseNumber(a);

if (a > 9999 && a < 1000000)
{
    if (reversed == a)
    {
        Console.WriteLine("Число является полиндромом.");
    }
    else
    {
        Console.WriteLine("Число НЕ является полиндромом.");
    }

}
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}