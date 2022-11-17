// задача 10
int n = new Random().Next(100, 1000);
Console.WriteLine("Полученное трехзначное число: " + n);
int D2 = (n/10)%10;
Console.WriteLine("Полученное 2-ая цифра: " + D2);


//Укороченный вариант

// задача 10
int n = new Random().Next(100, 1000);
Console.WriteLine("Полученное трехзначное число: " + n);
Console.WriteLine("Полученное 2-ая цифра: " + (n/10)%10);
