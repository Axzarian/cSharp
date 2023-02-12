System.Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int i = 1;

if (N > 0)
{
    while (i <= N)
    {
        if (i % 2 == 0)
        
        {
            Console.WriteLine(i);
        }
    i++;
    }
}
else 
{
    while (i >= N)
    {
        if (i % 2 == 0)
        {
            System.Console.WriteLine(i);
        }
        i--;
    }
}