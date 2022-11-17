//создание массива из рандомных 3-х значных положительных чисел

//Поиск количества четных элементов массива

//Создать массив n - элементов
int n;
Console.Write("Введите количество элементов массива: ");
if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
{
    Console.WriteLine("Введите верное значение длины массива ");
    return;
}
int[] array = new int[n];
//заполнить массив случайными положительными 3-х значными числами 
FillArray(array);
//вывод массива
PrintArr(array);
//Подсчет количества четных элементов
int Chet = sumChetEl(array);
Console.WriteLine($"сумма четных элементов массива равна = {Chet}");

//Функция заполнения массива случайными числами
void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
}
//Функция количества четных элементов массива
int sumChetEl(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            sum++;
    }
    return sum;
}
void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}" + "|");
    }
    Console.WriteLine();
}

