//Задать двухмерный массив
const int m = 5;
const int n = 5;
int[,] arr2 = new int[m, n];
FillArray2(arr2);
PrintArray2(arr2);
SumArray2(arr2);


void FillArray2(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(10);

}

void SumArray2(int[,] array)
{
    int minGetLength = array.GetLength(0);
    if (array.GetLength(1) < minGetLength)
        minGetLength = array.GetLength(1);
    int res = 0;
    for (int i = 0; i < minGetLength; i++)
    {
        res += array[i, i];
    }
    Console.WriteLine("Сумма главной диагонали = " + res);
}


void PrintArray2(int[,] array){

for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($" {array[i, j]} "+" | ");
    }
Console.WriteLine("  ");
}
}


