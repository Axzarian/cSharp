System.Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = a;

if (a == b)
{
    System.Console.WriteLine("Введенные вами числа равны");
}

else if (a > b)
{
    min = b;
    System.Console.WriteLine("Большее число: " + max);
    System.Console.WriteLine("Меньшее число: " + min);

} 
else 
{
    max = b;
    System.Console.WriteLine("Большее число: " + max);
    System.Console.WriteLine("Меньшее число: " + min);
} 