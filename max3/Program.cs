int numberA = new Random().Next(1,20);
Console.WriteLine(numberA);
int numberB = new Random().Next(1,20);
Console.WriteLine(numberB);
int numberC = new Random().Next(1,20);
Console.WriteLine(numberC);
int maxNumbers = numberA;
if(maxNumbers>numberB)
{
    Console.WriteLine(maxNumbers);
}
else
{
    maxNumbers=numberB;
}
if(maxNumbers>numberC)
{
    Console.WriteLine(maxNumbers);
}
else
{
    maxNumbers=numberC;
}

Console.WriteLine(maxNumbers + " максимальное значение из 3");

