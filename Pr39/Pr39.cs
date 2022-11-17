//Создать массив из 5 элементов
int[] array = new int[6];
//заполнить массив случайными числами 
FillArray(array);
//вывод массива
PrintArr(array);
// Замена положительных элементов на отрицательные
PrintArrZam(array);


//Функция заполнения массива случайными числами
void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0,11);
    }
}
//Функция вывода массива
void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}"+" | ");
    }
    Console.WriteLine();
}
//замена положительных замена
void PrintArrZam(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int res = arr[arr.Length-i-1];
        arr[arr.Length-i-1]=arr[i];
        arr[i]=res;
        Console.Write($"{arr[i]}"+" | ");
    }
    Console.WriteLine();
}
