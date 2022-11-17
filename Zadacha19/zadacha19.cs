int n;
Console.WriteLine("Введите чило 5 -ти значеое число: ");
if (!int.TryParse(Console.ReadLine(), out n) || n<0 || n>99999)
{
Console.WriteLine("Введите верное значение ");
return;
}
    string P = palindrom(n);
Console.WriteLine (P);

string palindrom(int i)
{   
    if ((i/10000 == i%10)&&(i/1000%10==i/10%10))
   return "Число является палиндромом";
      else 
   return "Число не является палиндромом"; 
 
}
