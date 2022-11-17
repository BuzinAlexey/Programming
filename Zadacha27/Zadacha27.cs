int n;
Console.WriteLine("Введите число : ");
if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
    Console.WriteLine("Введите верное значение ");
int Q = 0;
while (n > 0)
{
    Q= Q+n%10;
    n = n/10;
}

Console.WriteLine("Сумма цифр в числе: " + Q);