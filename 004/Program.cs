// Задача 13
int ShowThirdDigit(int n )
{
    
    if( n < 100)
    {
        n = 0;
        return n ;
    }
    else
    {
        while(n  > 1000)
        {
            n = n / 10;
        }
        n = n % 10;  
        return n ;
    }
    
}
Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int num = ShowThirdDigit(n );
if( num == 0) 
{
    Console.WriteLine("У числа нет третьей цифры");
}
else
{
    Console.WriteLine( "Третья цифра " + num);
}