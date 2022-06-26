
//Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

void ShowThirdDigit( int n)
{
    Console.Write("Введите число ");
    n = Convert.ToInt32(Console.ReadLine());
    if(n<100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        while( n > 1000);
        {
            n = n / 10;
        }
        n = n % 10;  
        Console.WriteLine (n);
    }
    
}

