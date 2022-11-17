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

int s;
Console.Write("Введите номер строки элемента: ");
if (!int.TryParse(Console.ReadLine(), out s) || s < 0)
{
    Console.WriteLine("Введите верное значение длины массива ");
    return;
}
int c;
Console.Write("Введите номер столбца элемента: ");
if (!int.TryParse(Console.ReadLine(), out c) || c < 0)
{
    Console.WriteLine("Введите верное значение длины массива ");
    return;
}


ElArray2(arr2, s, c);



void ElArray2(int[,] array, int i, int j)
{
          if (i<=array.GetLength(0)&&j<=array.GetLength(1))
          Console.WriteLine($"Элемент [{i},{j}] = {array[i, j]}");
          else
          Console.WriteLine($"Элемента [{i},{j}] = не существует");
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




