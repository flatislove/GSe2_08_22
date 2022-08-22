int result(int number)
{
    number = Math.Abs(number);
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

Console.Clear();
int number = 0;

while (true)
{
    Console.WriteLine("Введите число");
    if (int.TryParse(Console.ReadLine(), out number))
    {
        break;
    }
    else Console.WriteLine("Некорректный ввод");
}
Console.WriteLine((number > 99 || number < -99) ? result(number) : "Нет третьего числа");