// Программа для вычисления куба числа
Console.Write("Введите число :");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("число :" + x);

int  stepen = 1;
for (int i = 0; i < n; i++)
{
    stepen = x*stepen;
}

Console.WriteLine("результат возведения в степень : " + stepen);


