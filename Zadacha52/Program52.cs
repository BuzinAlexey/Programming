//Создать массив n - элементов
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

FillArray2(arr2);

PrintArray2(arr2);

AvrArray2(arr2,m);

void AvrArray2(int[,] array, int s)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        double avr = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        avr = sum / s;
        Console.WriteLine($"AVR  {j+1} столбца =  {avr} |    | Cумма столбца {j+1} = {sum} ");

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





