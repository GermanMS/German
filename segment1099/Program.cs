int number = new Random().Next(10,100);
Console.WriteLine($"{number} Случайное число");
int numberA= number/10;
int numberB= number%10;
if( numberA>numberB){
    Console.WriteLine($"цифра {numberA} больше");
}
else{
 Console.WriteLine($"цифра {numberB} больше");

}