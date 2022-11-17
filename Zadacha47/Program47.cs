//Задать двухмерный массив
const int m = 5;
const int n = 5;
double[,] arr2 = new double[m, n];
FillArray2(arr2);
PrintArray2(arr2);

void FillArray2(double[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.NextDouble()*1000;

}

void PrintArray2(double[,] array){

for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($" {array[i, j]} "+" | ");
    }
Console.WriteLine("  ");
}
}



