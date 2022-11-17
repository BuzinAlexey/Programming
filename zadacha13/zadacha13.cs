Console.WriteLine("Введите чило: ");
string str = Convert.ToDouble(Console.ReadLine()).ToString();
Console.WriteLine("Длина числа = " + str.Length);  
if (str.Length<3)
{
   Console.WriteLine("Третьей цифры слева не существует в этом числе"); 
}
else
{
Console.WriteLine("Третья цифра слева  =  " + str[2]);
}


