Console.Write("Введите номер дня недели (понедельник-1, вторник-2...): ");
int number = Convert.ToInt32(Console.ReadLine());

//int number = new Random().NextBytes(1,8);

if (number == 6 || number == 7)
{
    System.Console.WriteLine("Это выходной! Ура!");
}
else
{
    System.Console.WriteLine("Дуй на работу:)");
}
