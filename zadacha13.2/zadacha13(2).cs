Console.Write("Введите число :");
int n = Convert.ToInt32(Console.ReadLine());
if (n<100 )
    Console.WriteLine("третьей цифры слева в числе не существует");
else
while (n>1000)
    n = n/10;
    Console.WriteLine("третья цифра слева в числе = " + (n % 10));

