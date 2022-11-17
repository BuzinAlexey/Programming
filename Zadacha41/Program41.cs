// Программа подсчета количества введенных вариантов
string a;
int[] b = new int[int.MaxValue];
int i = 0;
Console.WriteLine("Введите элементы массива, что бы закончить ввод введите end:");
while ((a = Console.ReadLine()!) != "end") 
    b[i++] = Convert.ToInt32(a); 
Console.WriteLine("Числа: ");

int res=0;
for (int k = 0; k < i; k++) 
    {  
Console.WriteLine(b[k]);
res=k+1;
    }
    Console.WriteLine("Число введенных чисел ранво: " + res); 
   
