// Задача 15
void WeekDay(int n)
{
    if (n>0 && n<8)
    {

        if ( n == 6 | n == 7)
        { 
            Console.WriteLine("ДА");
        }
        else
        {
            Console.WriteLine("НЕТ");
        }
        
    }
    else 
    {
        Console.WriteLine("Нет такого дня недели");
    }
}
Console.Write("Введите день недели цифрой ");
int n = Convert.ToInt32(Console.ReadLine());
WeekDay(n);
