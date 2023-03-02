// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write($"Введите угловой коэффициент k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите угловой коэффициент k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine("======================");
    Console.WriteLine("Эти прямые параллельны");
    Console.WriteLine("======================");
}
else
{
    double x = Math.Round((b1 - b2) / (k2 - k1),2);
    double y = Math.Round(k1 * x + b1,2);
    Console.WriteLine("========================================");
    Console.WriteLine($"Координаты точки пересечения:({x};{y})");
    Console.WriteLine("========================================");
}
