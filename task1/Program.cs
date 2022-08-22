Console.Clear();
int number = 0;
while (true)
{
    Console.WriteLine("Введите трехзначное число");
    try
    {
        number = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception e)
    {
        Console.WriteLine("Некорректное значение. Введите трехзначное число");
    }

    if ((number > 99 && number < 1000) || (number < -99 && number > -1000))
    {
        break;
    }
    else
    {
        Console.WriteLine("Число не трехзначное");
    }
}
int number2 = (number / 10) % 10;
Console.WriteLine(Math.Abs(number2));