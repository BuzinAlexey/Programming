int k = EnterNumber();
Console.WriteLine($"Количество чисел : {k}");


int EnterNumber()
{
string a;
int b = 0;
int i = 0;
Console.WriteLine("Введите элементы массива, что бы закончить ввод введите (.) :");
while ((a = Console.ReadLine()) != ".")
{
    b = Convert.ToInt32(a);
    i++;
}
return i;
}
