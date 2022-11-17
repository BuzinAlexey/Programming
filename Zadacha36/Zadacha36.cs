// Программа для нахождения суммы элементов стоящих на четных позициях в массиве.
// Массив заполняется случайными двухзначными числами.
// Длина массива задается пользователем с клавиатуры
// Производится вывод созданного массива на экран

//Создать массив n - элементов
int n;
Console.Write("Введите количество элементов массива: ");
if (!int.TryParse(Console.ReadLine(), out n) || n<0)
{
Console.WriteLine("Введите верное значение длины массива ");
return;
}
int[] array = new int[n];
//заполнить массив случайными числами 
FillArray(array);
//вывод массива
PrintArr(array);
//Подсчет суммы элементов на четных позициях
int Chet = sumСhetEl(array);
Console.WriteLine($"сумма элементов четных позиций массива равна = {Chet}");

//Функция заполнения массива случайными числами
void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }
}
//Функция суммы элементов четных позиций массива
int sumСhetEl(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0)
            sum=sum+arr[i];
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


