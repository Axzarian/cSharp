// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int NumPow(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)   
    {        
        result = result * a;           
    }
    return result; 
}
Console.Write("Введите цифру которую хотите возвести в степень: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите в какую степень вы хотите ее возвести: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NumPow(a,b));
