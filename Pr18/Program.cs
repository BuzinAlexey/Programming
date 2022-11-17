int n;
Console.WriteLine("Введите четверть: ");
if (!int.TryParse(Console.ReadLine(), out n) || (n == 0) || (n > 4))
{
    Console.WriteLine("Четверть либо не существует или координаты (0,0) ");
    return;
}
string coord = quadrant(n); //Вызов функции
{
    Console.WriteLine(coord);
}

string quadrant(int q) //Функция вычисления 
{
  
    if ((q == 1))
        return "(x>0 y>0)";
    else if (q == 2)
        return "(x<0 y>0)";
    else if (q == 3)
        return "(x<0 y<0)";
    else if (q == 4)
        return "(x>0 y<0)";
    else
        return "(x=0 y=0)";

}
