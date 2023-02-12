System.Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0)
    {
        System.Console.WriteLine(i);
    }
}
