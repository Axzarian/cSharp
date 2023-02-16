Console.Write("Введите номер дня недели (понедельник-1, вторник-2...): ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7)
{
    System.Console.WriteLine("Такого дня недели не бывает, камон!?");
}

else if (number == 6 || number == 7)
{
    System.Console.WriteLine("Это выходной! Ура!");
}
else
{
    System.Console.WriteLine("Дуй на работу:)");
}
