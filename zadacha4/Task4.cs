// Программа поиска наибольшего числа 
Console.Write("Введите число 1:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2:");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3:");
int n3 = Convert.ToInt32(Console.ReadLine());
int MAX = n1;
if (n2 > MAX)
{
    MAX=n2;
}
if (n3 > MAX)
{
    MAX=n3;
}
Console.WriteLine("Максимальное число из 3-ех:" + MAX);