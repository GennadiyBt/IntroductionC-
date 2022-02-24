// Задача 1
/*Console.Write("Введите первое число:");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int value2 = Convert.ToInt32(Console.ReadLine());
if (value1 > value2)
{
    Console.Write("Большее число:");
    Console.WriteLine(value1);
    Console.Write("Меньшее число:");
    Console.WriteLine(value2);
}
if (value1 < value2)
{
    Console.Write("Большее число:");
    Console.WriteLine(value2);
    Console.Write("Меньшее число:");
    Console.WriteLine(value1);
}
if (value1 == value2)
{
    Console.Write("Они равны");
}
*/

// Задача 2
/*Console.Write("Введите первое число:");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int value2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число:");
int value3 = Convert.ToInt32(Console.ReadLine());
int max = value1;
if (max < value2)
{
    max = value2;
}
if (max < value3)
{
    max = value3;
}
Console.Write("Наибольшее число:");
Console.Write(max);
*/

// Задача 3
/*Console.Write("Введите целое число:");
int value = Convert.ToInt32(Console.ReadLine());
if (value%2 == 0)
{
    Console.Write("Введенное число является четным");
}
else
{
    Console.Write("Введенное число не является четным");
}
*/

// Задача 4
/*Console.Write("Введите целое число:");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 0)
{
    int count = 1;
    while (count <= N)
    {
        if (count%2 == 0)
        {
            Console.Write(count);
            Console.Write(" ");

        }
        count+=1;
    }
}

if (N <= 0)
{
    int count = -1;
    while (count >= N)
    {
        if (count%2 == 0)
        {
            Console.Write(count);
            Console.Write(" ");
        }
        count+=-1;
    }
}
if (N == 0)
{
    Console.Write("Четных чисел в указанном диапазоне нет");
}*/