// Программа для проверки дня недели
Console.WriteLine("Введите номер дня недели от 1 до 7 :");
int den = Convert.ToInt32(Console.ReadLine());
if ((den <= 0) | (den > 7))
    Console.WriteLine("тебе же написали, что надо вводить, попробуй еще раз");
else
    if ((den == 6)|(den == 7))
        Console.WriteLine("Cегодня выходной Ура!!!");
    else
        Console.WriteLine("Будте любезны поработать, пока еще будни");




