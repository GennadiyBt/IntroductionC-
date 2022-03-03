// Задача 10
/*
void FindSecond (int num)
{
    int second = num/10%10;
    Console.WriteLine("second digit is " + second);
}

Console.WriteLine("Введите исследуемое число:");
int num = Convert.ToInt32(Console.ReadLine());
FindSecond(num);
*/

// Задача 13
/*
void Num3 (int num)
{
    if(num/100 > 0)
    {
        while(num/1000 > 0)
        {
            num = num/10;
        }
        num = num%10;
        Console.WriteLine("третья цифра " + num);
    }
    else
    {
        Console.WriteLine("третьей цифры нет");
    }
    
}

Console.WriteLine("Введите исследуемое число:");
int num = Convert.ToInt32(Console.ReadLine());
Num3(num);*/

// Задача 15

/*
void Calendar(int num)
{
    if (num == 6 ^ num == 7)
    {
        Console.WriteLine("да, это выходной день");
    }
    else
    {
        Console.WriteLine("нет, это рабочий день");
    }
}

Console.WriteLine("Введите номер дня недели (целое число от 1 до 7):");
int num = Convert.ToInt32(Console.ReadLine());
Calendar(num);
*/


