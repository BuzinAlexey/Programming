//Задать двухмерный массив
const int m = 4;
const int n = 5;
int[,] arr2 = new int[m, n];
FillArray2(arr2);

PrintArray2(arr2);

ZamPrintArray2(arr2);

PrintArray2(arr2);

void FillArray2(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(10);

}

void PrintArray2(int[,] array){

for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j]}"+"|");
    }
Console.WriteLine(" ");
}
}

void ZamPrintArray2(int[,] array){

for (int i = 0; i < array.GetLength(0); i+=2){
    for (int j = 0; j < array.GetLength(1); j+=2)
    {
       {array[i, j]=array[i, j]*array[i, j];
    }
Console.WriteLine(" ");
}
}
}