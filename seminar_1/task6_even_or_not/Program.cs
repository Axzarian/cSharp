System.Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

if (a % 2 == 0)
{
    System.Console.WriteLine("Данное число четное.");
}
else
{
    System.Console.WriteLine("Данное число нечетное.");
}