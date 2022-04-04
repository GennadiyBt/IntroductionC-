// Задача 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
void NumberOfPositive(int M)
{
	int Number = 0;
	for(int i = 0; i < M; i++)
	{
		Console.Write("Введите следующее число: ");
		int N = Convert.ToInt32(Console.ReadLine());
		if(N > 0) {Number++;}
	}
	Console.Write("Среди чисел, введенных пользователем " + Number + " больше ноля.");
}
*/

// Задача 2: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива.
// Вывести массив в виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями.
/*
void Frame(int m, int n)
{
	int [,] array = new int [m, n];
    for(int i = 0; i < m; i++)
	{
		for(int j = 0; j < n; j++)
		{
			if(i == 0 ^ i == m-1) {array[i,j] = 1;}
			if(j == 0 ^ j == n-1) {array[i,j] = 1;}
            Console.Write(array[i,j] + " ");
		}
        Console.WriteLine("");
	}	
}
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Frame(m, n);
*/



