//
Console.Write("Введите число 1:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2:");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n2 == Math.Pow(n1,3))
    Console.WriteLine("число 2 является кубом числа 1");
else
    Console.WriteLine("число 2 не является кубом числа 1");
