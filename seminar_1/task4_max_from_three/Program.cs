System.Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);

int max = a;

if (b > max) max = b;
if (c > max) max = c;

System.Console.WriteLine("Максимальное число равно: " + max);