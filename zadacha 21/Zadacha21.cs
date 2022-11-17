
double x1,x2,y1,y2,z1,z2;

Console.WriteLine("Введите координату Х1: ");
if (!Double.TryParse(Console.ReadLine(), out x1))
{
Console.WriteLine("Введите верное значение координаты ");
return;
}
Console.WriteLine("Координаты точки А => ");
Console.WriteLine("Введите координату Y1: ");
if (!Double.TryParse(Console.ReadLine(), out y1))
{
Console.WriteLine("Введите верное значение координаты  ");
return;
}
Console.WriteLine("Введите координату Z1: ");
if (!Double.TryParse(Console.ReadLine(), out z1))
{
Console.WriteLine("Введите верное значение координаты  ");
return;
}
Console.WriteLine("Введите координату Х2: ");
if (!Double.TryParse(Console.ReadLine(), out x2))
{
Console.WriteLine("Введите верное значение координаты ");
return;
}


Console.WriteLine("Введите координату Y2: ");
if (!Double.TryParse(Console.ReadLine(), out y2))
{
Console.WriteLine("Введите верное значение координаты  ");
return;
}
Console.WriteLine("Введите координату Z2: ");
if (!Double.TryParse(Console.ReadLine(), out z2))
{
Console.WriteLine("Введите верное значение координаты  ");
return;
}
double q = razmer (x1,y1,z1,x2,y2,z2); 

{
Console.WriteLine("Расстояние равно  " + q);
}

double razmer (double i1, double j1, double k1,double i2, double j2, double k2) 
{
   return Math.Sqrt(Math.Pow(i1-i2,2)+Math.Pow(j1-j2,2)+Math.Pow(k1-k2,2));
}

