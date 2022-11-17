int n;
Console.Write("Введите число: ");
if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
{
    Console.WriteLine("Введите верное значение ");
    return;
}
Numbers(n);
Console.WriteLine($"ведите верное значение{n}");


void Numbers(int i)
{
    if (i == 1)
    {
        Console.WriteLine();
    }

    else
    {
        Numbers(i - 1);
        i--;
        Console.WriteLine(i);
    }

}
