//программа, которая упорядочит по убыванию элементы каждой строки двумерного массива
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

StringArray2(arr2);
Console.WriteLine();
PrintArray2(arr2);


void StringArray2(int[,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = array.GetLength(1) - 1; j > i; j--)
                if (array[k, j] > array[k, j - 1])
                {
                    int change = array[k, j];
                    array[k, j] = array[k, j - 1];
                    array[k, j - 1] = change;
                }
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
            array[i, j] = rnd.Next(10,100);

}







