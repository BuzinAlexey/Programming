// Программа для вычисления максимального числа в массиве введеного с клавиатуры
string a;
int b = 0;
int i = 0;
Console.WriteLine("Введите элементы массива, что бы закончить ввод введите (.) :");
while ((a = Console.ReadLine()) != ".")
{
    b = Convert.ToInt32(a);
    i++;
}
Console.WriteLine($"количество введенных чисел : {i}");




