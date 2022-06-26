 //Задача 10
 
 int ShowSecondDigit(int number)
{
int num1 = number % 100;
int num2 = num1/10;
return num2;
}

Console.Write("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());

if ( number > 999 | number < 100) 
{
    Console.WriteLine("Число не является трехзначным: ");
}
else
{
int digit = ShowSecondDigit( number);

Console.WriteLine("Вторая цифра " + digit);
}