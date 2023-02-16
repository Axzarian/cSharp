//int num = 45263; used to check all lengthes

int num = new Random().Next(-99999,100000);
int number = Math.Abs(num);

System.Console.WriteLine(num);

if(number < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}

else if(number >=100 && number < 1000)
{
    int result3 = number % 10;
    System.Console.WriteLine(result3);
}

else if(number >=1000 && number < 10000)
{
    int result4 = number / 10 % 10;
    System.Console.WriteLine(result4);
}

else if(number >=10000 && number < 100000)
{
    int result5 = number / 100 % 10;
    System.Console.WriteLine(result5);
}