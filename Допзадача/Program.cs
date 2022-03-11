Console.WriteLine("Введите исследуемое число:");
int num = Convert.ToInt32(Console.ReadLine());

int max1 = num;
int max2 = num;
int min1 = num;
int min2 = num;
if (num == 0)
{
    Console.WriteLine("Объектов для исследования нет. Задача прервана.");
}
else
{
    Console.WriteLine("Введите следующее число:");
    num = Convert.ToInt32(Console.ReadLine());
    if(num == 0)
    {
        Console.WriteLine(max1 + " " + max2 + " " + min1 + " " + min2);
    }
    else
    {
        if(num > max1)
        {
            max2 = max1;
            max1 = num;
            min1 = num;
        }
        else
        {
            max2 = num;
            min2 = num;
        }
        if(min2 > min1)
        {
            int prom = min2;
            min2 = min1;
            min1 = min2;
        }
        
    }
        Console.WriteLine("Введите следующее число:");
        num = Convert.ToInt32(Console.ReadLine());
        while (num > 0 ^ num < 0)
        {

            if(num >= max1)
            {
                max2 = max1;
                max1 = num;
            }
            if(num < max1 && num > max2)
            {
                max2 = num;
            }
            if(num < min2)
            {
                min1 = min2;
                min2 = num;
            }
            if(num > min2 && num < min1)
            {
                min1 = num;
            }
            if((num == min2 && num == max2)^(num == min2 && num < min1))
            {
                min1 = num;
            }
            Console.WriteLine("Введите следующее число:");
            num = Convert.ToInt32(Console.ReadLine());
        }      
        Console.WriteLine(max1 + " " + max2 + " " + min1 + " " + min2);
}