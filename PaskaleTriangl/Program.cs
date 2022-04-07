/*
for (i = 0; i < n; i++)
{
    for (c = 0; c <= (n - i); c++) // создаём после каждой строки n-i отступов от левой стороны консоли, чем ниже строка, тем меньше отступ
    {
        Console.Write(" ");
    }
    for (c = 0; c <= i; c++)
    {
        Console.Write(" "); // создаём пробелы между элементами треугольника
        Console.Write(factorial(i) / (factorial(c) * factorial(i - c))); //формула вычисления элементов треугольника
    }
    Console.WriteLine();
    Console.WriteLine(); // после каждой строки с числами отступаем две пустые строчки
}
Console.ReadLine();
*/

int[,] CreateTriangl(int size)
{
    int[,] triangle = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }
    for (int i = 2; i < size; i++)
    {
        for (int j = 1; j < size; j++)
        {
            triangle[i,j] = triangle[i-1,j-1] + triangle[i-1,j];
        }
    }
    return triangle;
}

Console.WriteLine("Введите нужное количество строк треугольника Паскаля:");
int n = Convert.ToInt32(Console.ReadLine());

/*
for (int i = 0; i < n; i++)
{
    for (int j = 0; j <= (n - i); j++) // создаём после каждой строки n-i отступов от левой стороны консоли, чем ниже строка, тем меньше отступ
    {
        Console.Write(" ");
    }
    for (int j = 0; j <= i; j++)
    {
        Console.Write(" "); // создаём пробелы между элементами треугольника
        Console.Write(CreateTriangl(n)[i, j]); //формула вычисления элементов треугольника
    }
    Console.WriteLine();
    Console.WriteLine(); // после каждой строки с числами отступаем две пустые строчки
}
*/

for (int i = 0; i < n; i++)
{
    for (int j = 0; j <= (n - i); j++) // создаём после каждой строки n-i отступов от левой стороны консоли, чем ниже строка, тем меньше отступ
    {
        Console.Write("  ");
    }
    for (int j = 0; j <= i; j++)
    {
        Console.Write(" "); // создаём пробелы между элементами треугольника
        if(CreateTriangl(n)[i, j] < 10) {Console.Write(" " + CreateTriangl(n)[i, j] + " ");}
        if(CreateTriangl(n)[i, j] >= 10 && CreateTriangl(n)[i, j] < 100) {Console.Write(CreateTriangl(n)[i, j] + " ");}
        if(CreateTriangl(n)[i, j] >= 100) {Console.Write(CreateTriangl(n)[i, j]);}
    }
    Console.WriteLine();
    Console.WriteLine(); // после каждой строки с числами отступаем две пустые строчки
}