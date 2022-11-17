double a;
double b;
double c;

Console.WriteLine("Введите 1 сторону треугольника А: ");
if (!Double.TryParse(Console.ReadLine(), out a) || a<=0)
{
Console.WriteLine("Введите верное значение  ");
return;
}

Console.WriteLine("Введите 2 сторону треугольника B: ");
if (!Double.TryParse(Console.ReadLine(), out b) || b<=0)
{
Console.WriteLine("Введите верное значение  ");
return;
}

Console.WriteLine("Введите 3 сторону треугольника C: ");
if (!Double.TryParse(Console.ReadLine(), out c) || c<=0)
{
Console.WriteLine("Введите верное значение ");
return;
}

string T = Treugol(a,b,c); //Вызов функции
{
    Console.WriteLine(T);
}

string Treugol(double i,double j,double k ) //Функция вычисления 
{
  
    if (i>=(j+k)) 
        return "(треугольника не существует)";
    else if (j>=(i+k) )
        return "(треугольника не существует)";
    else if (k>=(j+i)) 
        return "(треугольника не существует)";
    else
        return "(УРА треугольник )";

}

