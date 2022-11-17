//Задать двухмерный массив
const int m = 6;
const int n = 6;
int[,] arr2 = new int[m, n];

FillArray2(arr2);

PrintArray2(arr2);

void FillArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = i+j;
}

void PrintArray2(int[,] array){

for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($" {array[i, j]} | ");
    }
Console.WriteLine("  ");
}
}