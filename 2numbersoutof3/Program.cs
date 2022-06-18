int number = new Random().Next(100,1000);
Console.WriteLine($"{number} Случайное число");
int numberB = number / 100;
int numberC = number / 10 % 10;
int numberD = number % 10;
int numberA = numberB * 10 + numberD;
Console.WriteLine($"{numberA}");
