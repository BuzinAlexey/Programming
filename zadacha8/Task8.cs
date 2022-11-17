// Пограмма выводит список всех четных чисел от 1 до N
Console.Write("Введите число N:");
int x = Convert.ToInt32(Console.ReadLine());
if (x <= 0)
{
    Console.WriteLine("Введите число больше 0 ");
}
else
{
    int i = 2;
    while (i <= x)
    {

        Console.WriteLine("Четное число ->  " + i);
        i += 2;
    }
}


