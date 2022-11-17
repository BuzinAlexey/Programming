//замена строк и столбцов местами
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

if (m==n)
AvrArray2(arr2);
else
Console.WriteLine("строки должны быть равны столбцам");

Console.WriteLine("  ");

PrintArray2(arr2);


void AvrArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i+1; j < array.GetLength(1); j++)
        {
            int change = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = change; 
        }
        
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






