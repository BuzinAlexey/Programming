// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

Console.Write("Введите число 1:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 % number2 == 0)
    Console.WriteLine("число 1 кратно чиcлу 2: ");
else
    Console.WriteLine("число 1 не кратно чиcлу 2, остаток от деления равен: " 
    + (number1 % number2));
