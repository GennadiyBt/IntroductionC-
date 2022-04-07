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
Console.WriteLine("Введите размерs массива (число строк и число столбцов): ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
*/
/*
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
	{
		for(int j = 0; j < array.GetLength(1); j++)
		{
            Console.Write(array[i,j] + " ");
		}
        Console.WriteLine("");
	}	
}
*/
//Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] SortingMatrix(int[,] array)
{
    int temp;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i,j] < array[i,k])
                {
                    temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                }
            }
            Console.Write(array[i,j] + " ");
        }
        Console.Write(array[i, (array.GetLength(1)-1)] + " ");
        Console.WriteLine("");
    }
    return array;
}

int[,] TempArray = RandomArray(m,n);
Console.WriteLine("");
SortingMatrix(TempArray);
*/


//Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
void RowMinSum(int[,] array)
{
    int minnum = 0, minsum = array[0, 0];
    for(int j = 1; j < array.GetLength(1); j++)
    {
        minsum = minsum + array[0, j];
    }
    for(int i = 1; i < array.GetLength(0); i++)
	{
        int temp = 0;
		for(int j = 0; j < array.GetLength(1); j++)
		{
			temp = temp + array[i, j];
        }
        if(minsum > temp)
        {
            minsum = temp;
            minnum = i;
        }
	}	
    Console.WriteLine("Строка с минимальной суммой элементов имеет номер " + minnum);
}

int[,] array = {{9,8,7},{4,5,6},{1,2,3}};
RowMinSum(array);
*/

//Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] TwoDidgitArray(int row, int column, int depth)
{
    int[,,] array = new int[row,column,depth];
    int temp = 99;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                if(temp >= 10){array[i,j,k] = temp;}
                else {array[i,j,k] = temp - 19;}
                temp--;
            }
        }
    }
    return array;
}

void StrVision(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i,j,k] + " (" + i + "," + j + "," + k + ") ");
            }
            Console.WriteLine("");
        }
    }
}

Console.WriteLine("Введите размерность трехмерного массива: высоту, ширину и глубину.");
Console.WriteLine("Помните, что емкость массива неповторяющихся двузначных чисел конечна и равна 180 элементов!");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());

StrVision(TwoDidgitArray(m,n,d));
*/
// Задача 4: Заполните спирально массив 4 на 4.
/*
int[,] SnailArray(int n)
{
   int[,] matrix = new int[n,n];
   int b = 1, l = n, k = n, l0 = 0, k0 = 0;
   while(l0 < l)
   {
       for(int j = l0; j < l; j++)
       {
           matrix[k0, j] = b;
           b++;
       }
       l = l - 1;
       for( int i = (k0 + 1); i < k; i++)
       {
           matrix[i, k-1] = b;
           b++;
       }
       k = k - 1;
       for(int j = (l-1); j >= l0; j=j-1)
       {
           matrix[l, j] = b;
           b++;
       }
       for(int i = (k-1); i > k0; i = i-1)
       {
           matrix[i, l0] = b;
           b++;
       }
       l0++; k0++;
   }
   return matrix;
}
Console.WriteLine("Введите размер квадратного массива n: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintArray(SnailArray(n));
*/
