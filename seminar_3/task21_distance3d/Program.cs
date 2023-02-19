System.Console.Write("Введите x1:");
int x1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите y1:");
int y1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите z1:");
int z1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите x2:");
int x2 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите y2:");
int y2 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите z2:");
int z2 = Convert.ToInt32(Console.ReadLine());



double S = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

System.Console.WriteLine(Math.Round(S, 2));
