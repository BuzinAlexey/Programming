//замена строк и столбцов местами
int m;
Console.Write("Введите количество строк массива 1: ");
if (!int.TryParse(Console.ReadLine(), out m) || m < 0)
{
    Console.WriteLine("Введите верное значение длины массива ");
    return;
}
int n;
Console.Write("Введите количество столбцов массива 1: ");
if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
{
    Console.WriteLine("Введите верное значение длины массива ");
    return;
}
Console.WriteLine("  ");
int s;
Console.Write("Введите количество строк массива 2: ");
if (!int.TryParse(Console.ReadLine(), out s) || s < 0)
{
    Console.WriteLine("Введите верное значение длины массива ");
    return;
}
int r;
Console.Write("Введите количество столбцов массива 2: ");
if (!int.TryParse(Console.ReadLine(), out r) || r < 0)
{
    Console.WriteLine("Введите верное значение длины массива ");
    return;
}


int[,] arrMN = new int[m, n];
int[,] arrSR = new int[s, r];

FillArray2(arrMN);
FillArray2(arrSR);

PrintArray2(arrMN);
Console.WriteLine("  ");
PrintArray2(arrSR);
Console.WriteLine("  ");

if ((m == r) && (n == s))
{
    int[,] a = UmnArray2(arrMN, arrSR);
    PrintArray2(a);
}

else
    Console.WriteLine("Нельзя перемножить данные матрицы");


int[,] UmnArray2(int[,] array1, int[,] array2)
{
    int[,] arrRes = new int[m, r];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                arrRes[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return arrRes;

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







