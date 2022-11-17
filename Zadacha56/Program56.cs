//нахождение строки с минимальной суммой элементов
int m;
Console.Write("Введите количество строк массива: ");
if (!int.TryParse(Console.ReadLine(), out m) || m < 0)
{
    Console.WriteLine("Введите верное значение длины массива ");
    return;
}
int n;
Console.Write("Введите количество столбцов массива: ");
if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
{
    Console.WriteLine("Введите верное значение длины массива ");
    return;
}
int[,] arr2 = new int[m, n];
int[] sum = new int[arr2.GetLength(0)];

FillArray2(arr2);

PrintArray2(arr2);

SumStringArray2(arr2);

MinimalSum(sum);

void MinimalSum(int[] sum)
{
    int min = sum[0];
    for (int i = 0; i < sum.Length; i++)
    {
        if (min > sum[i])
            min = sum[i];
    }
    Console.WriteLine($"| Минимальная сумма = {min}|");

}

void SumStringArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i, j];

        }
        Console.WriteLine($"| Cумма строки {i + 1} = {sum[i]}|");

    }
}


void PrintArray2(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} " + " | ");
        }
        Console.WriteLine("  ");
    }
}

void FillArray2(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(10);

}






