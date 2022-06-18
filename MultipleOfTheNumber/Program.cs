Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = numberA % numberB;
if (numberC ==0 ){
    Console.WriteLine(" Первое число кратно второму ");
}
else{
    Console.WriteLine($"{numberC} остаток от деления");
}