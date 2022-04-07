/*
int[,] RandomArray(int row, int column)
{
    int[,] array = new int[row, column];
    for(int i = 0; i < row; i++)
	{
		for(int j = 0; j < column; j++)
		{
			array[i,j] = new Random().Next(-9, 10);
            Console.Write(array[i,j] + " ");
		}
        Console.WriteLine("");
	}	
    return array;
}
*/
//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
void RandomDoubleArray(int m, int n)
{
    double[,] array = new double[m, n];
    for(int i = 0; i < m; i++)
	{
		for(int j = 0; j < n; j++)
		{
			array[i,j] = Math.Round(new Random().Next(-9, 10) + new Random().NextDouble(), 1);
            Console.Write(array[i,j] + " ");
		}
        Console.WriteLine("");
	}	
}
*/
//Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
string ElementValue(int[,] matrix, int m, int n)
{
    if((m >= 0 && m < matrix.GetLength(0)) && (n >= 0 && n < matrix.GetLength(1)))
    {
        return Convert.ToString(matrix[m, n]);
    }
    else {return "Такого элемента в массиве нет.";}

}
Console.WriteLine("Введите номер искомой позиции (номер строки, номер столбца): ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(ElementValue(RandomArray(4,5), m, n));
*/
//Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
void ColumnAverage(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j,i];
        }
        double average = (double)sum/array.GetLength(0);
        Console.WriteLine("Среднее арифметическое столбца " + i + " равно " + Math.Round(average, 1));
    }
}
int[,] array = {{1,4,7,2},{5,9,2,3},{8,4,2,4}};
ColumnAverage(array);
*/