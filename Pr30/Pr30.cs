//Создать массив из 12 элементов
int[] array = new int[12];
//заполнить массив случайными числами от -9 до 9
FillArray(array, -9, 9);
//вывод массива
PrintArr(array);
// найти сумму отрицательных элементов
int sumNeg = SumNegativeElements(array);
Console.WriteLine($"сумма отрицательных элементов массива равна = {sumNeg}");
// найти сумму положительных элементов
int sumPos = SumPositiveElements(array);
Console.WriteLine($"сумма положительных элементов массива равна = {sumPos}");

void FillArray(int[] arr, int minVal, int maxVal)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minVal, maxVal + 1);
    }
}
//подсчет отрицательных элементов
int SumNegativeElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
            sum += arr[i];
    }
    return sum;
}
//подсчет положительных элементов
int SumPositiveElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            sum += arr[i];
    }
    return sum;
}
void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}"+"|");
    }
    Console.WriteLine();
}