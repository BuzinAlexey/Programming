//программа, которая упорядочит по убыванию элементы каждой строки двумерного массива
int m;
Console.Write("Введите размерность строки массива: ");
if (!int.TryParse(Console.ReadLine(), out m) || m < 0)
{
    Console.WriteLine("Введите верное значение длины массива ");
    return;
}
int n;
Console.Write("Введите размерность столбца массива: ");
if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
{
    Console.WriteLine("Введите верное значение длины массива ");
    return;
}

FillArray2(m,n);


void FillArray2(int M, int N)
{
    int[,] a = new int[M, N];
     
        for (int i = 0, j = n * n; i < j;) 
        int x = 0;
        int y = 0;
        int z = n;{
            a[x,y] = j - i++ : ++i;

            if (x < z + (n - z) / 2 - 1 && y == (n - z) / 2) {
                x++;
            } else if (x == z + (n - z) / 2 - 1 && y < z + (n - z) / 2 - 1) {
                y++;
            } else if (x > (n - z) / 2 && y == z + (n - z) / 2 - 1) {
                x--;
            } else if (x == (n - z) / 2 && y > (n - z) / 2 + 1) {
                y--;
            } else {
                x++;
                z -= 2;
            }
        }

        return matrix;
    }
 
    }
     for (int x = 0; x < a.GetLength(0); x++)
    {
        for (int y = 0; y < a.GetLength(1); y++)
        {
            Console.Write($" {a[i, j]} " + " | ");
        }
        Console.WriteLine("  ");
    }
}










