Console.Write("Введите первое число:");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int value2 = Convert.ToInt32(Console.ReadLine());
if (value2*value2 == value1)
{
    Console.WriteLine("Да, является");
}
else
{
    Console.WriteLine("Нет, не является");
}