int n;
Console.Write("Введите число: ");
if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
{
    Console.WriteLine("Введите верное значение ");
    return;
}
int m;
Console.Write("Введите степень: ");
if (!int.TryParse(Console.ReadLine(), out m) || m < 0)
{
    Console.WriteLine("Введите верное значение ");
    return;
}
int k = Pow(n,m);
Console.WriteLine($"степень {k}");

int Pow(int x, int y)
{
if (y==0)
return 1;
return x*Pow(x,--y);
}












