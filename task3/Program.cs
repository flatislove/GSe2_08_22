Console.Clear();
int number = 0;

while (true)
{
    Console.WriteLine("Введите число, соответствующее дню недели");
    if (int.TryParse(Console.ReadLine(), out number) && number < 8 && number > 0)
    {
        break;
    }
    else Console.WriteLine("Некорректный ввод");
}
Console.WriteLine(number < 6 ? "Выходной? Нет(" : "Выходной? Да)");