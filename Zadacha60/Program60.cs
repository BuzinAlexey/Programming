//нахождение строки с минимальной суммой элементов
int x;
Console.Write("Введите размерность 1 массива: ");
if (!int.TryParse(Console.ReadLine(), out x) || x < 0)
{
    Console.WriteLine("Введите верное значение длины массива ");
    return;
}
int y;
Console.Write("Введите размерность 2 массива: ");
if (!int.TryParse(Console.ReadLine(), out y) || y < 0)
{
    Console.WriteLine("Введите верное значение длины массива ");
    return;
}
int z;
Console.Write("Введите размерность 3 массива: ");
if (!int.TryParse(Console.ReadLine(), out z) || z < 0)
{
    Console.WriteLine("Введите верное значение длины массива ");
    return;
}

int[,,] arr3 = new int[x, y, z];


FillArray2(arr3);

if (x * y * z <= 90)
    PrintArray2(arr3);
else
    Console.WriteLine("Количество элементов 3-х мерного массива больше 90");



void PrintArray2(int[,,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"| El [{i + 1},{j + 1},{k + 1}] = {array[i, j, k]} |");
            Console.WriteLine();
        }
    }
}

void FillArray2(int[,,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                array[i, j, k] = GenerateUniqueNumber();

}

int GenerateUniqueNumber()
{
    HashSet<int> numbers = new HashSet<int>();
    Random rnd = new Random();
    while (true)
    {
        int n = rnd.Next(10, 100);
        if (!numbers.Contains(n))
        {
            numbers.Add(n);
            return n;
        }
    }
}





