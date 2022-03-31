// Задача 1
/*
Console.Write("Метод, реализующий случайный двумерный массив.");

void RandomArray(int m, int n)
{
    int [,] array = new int [m, n];
    for(int i = 0; i < m; i++)
	{
		for(int j = 0; j < n; j++)
		{
			int prom = new Random().Next(-99,100);
			if(prom/10 == 0) {array[i, j] = prom*10;}
			else {array[i,j] = prom;}
            Console.Write(array[i,j] + " ");
		}
        Console.WriteLine("");
	}
}
*/

/*
Console.Write("Метод, реализующий вторую задачу.");
void SumIndexArray(int m, int n)
{
    int [,] array = new int [m, n];
    for(int i = 0; i < m; i++)
	{
		for(int j = 0; j < n; j++)
		{
			array[i,j] = i + j;
            Console.Write(array[i,j] + " ");
		}
        Console.WriteLine("");
	}
}
*/
/*
Console.Write("Метод, реализующий третью задачу.");
void SqwEvenIndex(int m, int n)
{
    int [,] array = new int [m, n];
    for(int i = 0; i < m; i++)
	{
		for(int j = 0; j < n; j++)
		{
			array[i,j] = new Random().Next(1,10);
            Console.Write(array[i,j] + " ");
		}
        Console.WriteLine("");
	}
	Console.WriteLine("");
	for(int i = 0; i < m; i++)
	{
		for(int j = 0; j < n; j++)
		{
			if(i%2 == 0 && j%2 == 0){array[i, j] = array[i, j]*array[i, j];}
            Console.Write(array[i,j] + " ");
		}
        Console.WriteLine("");
	}
}
*/
/*
Console.Write("Метод, реализующий четвертую задачу.");
void SumDiagArray(int m)
{
    int [,] array = new int [m, m];
    for(int i = 0; i < m; i++)
	{
		for(int j = 0; j < m; j++)
		{
			array[i,j] = new Random().Next(1,10);
            Console.Write(array[i,j] + " ");
		}
        Console.WriteLine("");
	}
	int sum = 0;
	for(int i = 0; i < m; i++)
	{
		sum = sum + array[i, i];
	}
	Console.WriteLine("Сумма элементов, находящихся на главной диагонали равна " + sum);
}
*/