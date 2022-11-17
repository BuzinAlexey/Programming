Console.WriteLine("Введите коэфициент k1: ");
double k1 = EnterNumber();
Console.WriteLine("Введите коэфициент b1 : ");
double b1 = EnterNumber();
Console.WriteLine("Введите коэфициент k2 : ");
double k2 = EnterNumber();
Console.WriteLine("Введите коэфициент b2 : ");
double b2 = EnterNumber();

if ((k1 == k2) && (b1 == b2))
    Console.WriteLine("прямые совпадают");
else if (k1 == k2)
    Console.WriteLine("прямые параллельны");
else Console.WriteLine($"Координата пересечения [X,Y]= [{(b2 - b1) / (k1 - k2)} | {k1 * (b2 - b1) / (k1 - k2) + b1}]");

double EnterNumber()
{
double n;
if (!double.TryParse(Console.ReadLine(), out n))
{
    Console.WriteLine("Введите верное значение ");
}
    return n;
}