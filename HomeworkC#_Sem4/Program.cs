// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
double Exp(double A, int B)
{
    double result = 1;
    if (B > 0)
    {
        for(int i = 1; i <= B; i++)
        {
            result = result*A;
        }
    }

    return result;
}

Console.Write("Введите основание степени A: ");
double base_num = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите показатель степени (натуральное число) B: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write(base_num + " в степени " + N + " равняется " + Exp(base_num, N));
*/

//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Sum(int num)
{
    if(num < 0)
    {
        num = -1*num;
    }
    int result = num%10;
    while(num/10 > 0)
    {
        num = num/10;
        result = result + num%10;
    }
    return result;
}

Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Сумма цифр числа "  + N + " равняется " + Sum(N));
*/

//Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
void Free_Array(int N)
{
    int[] array = new int [N];
    for(int i = 0; i < N; i++)
    {
        Console.Write("Введите следующий элемент массива:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

Console.Write("Введите желаемую размерность массива: ");
int Size = Convert.ToInt32(Console.ReadLine());
Free_Array(Size);
*/