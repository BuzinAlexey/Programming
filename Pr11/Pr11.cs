 
double x;
double y;

Console.WriteLine("Введите координату Х: ");
if (!Double.TryParse(Console.ReadLine(), out x) || x==0)
{
Console.WriteLine("Введите верное значение координаты ");
return;
}


Console.WriteLine("Введите координату Y: ");
if (!Double.TryParse(Console.ReadLine(), out y) || y==0)
{
Console.WriteLine("Введите верное значение координаты  ");
return;
}

int q = quadrant (x,y); // Вызов функции вычисления четверти
print(x,y,q);
void print(double x, double y, int q)
{
Console.WriteLine("Точка => " + x + " , " + y + "четверть =>" + q);
}

int quadrant(double i, double j) //Функция вычисления четверти координаты
{
    if ((i > 0) && (j > 0))
        return 1;
    else if ((i < 0) && (j > 0))
        return 2;
    else if ((i < 0) && (j < 0))
        return 3;
         else if ((i > 0) && (j < 0))
        return 4;
   else 
   return 0;

}







