// Пограмма сравнения двух чисел. 
Console.Write("Введите число 1:");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2:");
int y = Convert.ToInt32(Console.ReadLine());
if (x == y)
{
    Console.WriteLine("1-ое число РАВНО 2-ому числу");
}
if (x > y)
{
    Console.WriteLine("1-ое число MAX, 2-ое MIN:");
}
if (x < y)
{
    Console.WriteLine("2-ое число MAX, 1-ое MIN:");
}



