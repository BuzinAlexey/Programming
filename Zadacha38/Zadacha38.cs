//Создать массив n - элементов
int n;
Console.Write("Введите количество элементов массива: ");
if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
{
    Console.WriteLine("Введите верное значение длины массива ");
    return;
}
double[] array = new double[n];
//заполнить массив случайными числами 
FillArray(array);
//вывод массива
PrintArr(array);
//Подсчет суммы нечетных элементов
double min = minimal(array);
double max = maximal(array);
Console.WriteLine($"Разница равна MAX[i]-MIN[i] = {max - min}");

//Функция заполнения массива случайными числами
void FillArray(double[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble()*1000;
    }
}
//Функция поиска минимального значения
double minimal(double[] arr)
{
    min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        min = arr[0];
        if (arr[i] < min)
            min = arr[i];
    }
    return min;
}
//Функция поиска максимального значения
double maximal(double[] arr)
{
    max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
    }
    return max;
}
//Функция вывода массива
void PrintArr(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}" + " | ");
    }
    Console.WriteLine();
}




