int numberA = new Random().Next(1,20);
Console.WriteLine(numberA + "первое случайное число");
int numberB = new Random().Next(1,20);
Console.WriteLine(numberB + "второе случайное число");
int numberC = new Random().Next(1,20);
Console.WriteLine(numberC +  "третье случайное число");
int maxNumbers = numberA;
if(maxNumbers>numberB);
else
{
    maxNumbers=numberB;
}
if(maxNumbers>numberC);

else
{
    maxNumbers=numberC;
}
Console.WriteLine(maxNumbers + " максимальное значение из 3");
