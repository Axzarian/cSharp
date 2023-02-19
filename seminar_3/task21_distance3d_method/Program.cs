int Prompt (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

double Distance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double S = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    double result = Math.Round(S,2);
    return result;
}

int x1 = Prompt("Введите координату x1: ");
int y1 = Prompt("Введите координату y1: ");
int z1 = Prompt("Введите координату z1: ");
int x2 = Prompt("Введите координату x2: ");
int y2 = Prompt("Введите координату y2: ");
int z2 = Prompt("Введите координату z2: ");

double result = Distance(x1,y1,z1,x2,y2,z2);
Console.WriteLine(result);
