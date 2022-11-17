//Создать массив из 5 элементов
int[] array = new int[5];
//заполнить массив случайными числами 
FillArray(array);
//вывод массива
PrintArr(array);
// Замена положительных элементов на отрицательные
PrintArrZam(array);

PrintArr(array);

//Функция заполнения массива случайными числами
void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-100,100);
    }
}
//Функция вывода массива
void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}"+"|");
    }
    Console.WriteLine();
}
//замена положительных на отрицательные
void PrintArrZam(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]=arr[i]*(-1)}"+"|");
    }
    Console.WriteLine();
}


