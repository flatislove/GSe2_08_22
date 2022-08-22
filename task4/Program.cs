int Avg(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }
    return sum / array.Length;
}
int Min(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
    }
    return min;
}
String Check(int avg, int min)
{
    while (min > 10)
    {
        min = min / 10;
    }
    Console.WriteLine("Последняя цифра среднего = " + avg % 10);
    Console.WriteLine("Первая цифра минимального = " + min);
    if (avg % 10 > min)
    {
        return "Да. Больше";
    }
    else if (avg % 10 == min)
    {
        return "Равны";
    }
    else return "Нет. Меньше";
}

Console.Clear();
int[] array = new int[3];

for (int i = 0; i < 3; i++)
{
    Console.Write("Введите трехзначное число #" + Convert.ToInt32(i + 1) + " = ");
    if (int.TryParse(Console.ReadLine(), out array[i]) && array[i] > 99 && array[i] < 1000)
    {
        Console.Write(" - OK\n");
    }
    else
    {
        i--;
        Console.WriteLine("Некорректный ввод");
    }
}
Console.WriteLine("Среднее арифметическое чисел = " + Avg(array));
Console.WriteLine("Минимальное значение = " + Min(array));
Console.WriteLine(Check(Avg(array), Min(array)));


