// Задача 1
/*
Console.WriteLine("Введите длину сторон треугольника: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int C = Convert.ToInt32(Console.ReadLine());

if ((A+B)>C && (A+C)>B && (B+C)>A)
{
    Console.Write("Такой треугольник может существовать");

}
else
{
    Console.Write("Такой треугольник не может существовать");
}
*/

//Задача 2
/*
Console.Write("Введите число, которое нужно перевести в двоичную систему: ");
int Num = Convert.ToInt32(Console.ReadLine());

//double Long = Math.Log(Num, 2);

int L = Convert.ToInt32(Math.Log(Num, 2)) +1;
Console.WriteLine(Math.Log(Num, 2));
int [] array = new int [L];
int D = Num, ost = D%2;
int i = 0;
while (D >= 2)
{
	array[i] = ost;
	D = D/2;
	ost = D%2;
	i = i+1;
}
array[i] = D;
int [] Num_Sist2 = new int [L];
for(i = 0; i<L; i++)
{
    Num_Sist2[i] = array[L-1-i];
}

Console.WriteLine("[{0}]", string.Join(" ", Num_Sist2));

//Math.Log(1.2, 0.1)
*/
//Задача 4
/*
int[,] Copy (int [,] array)
{
	int [,] copy_array = new int [array.GetLength(0),array.GetLength(1)];
	for(int i = 0; i < array.GetLength(0); i++)
	{
		for(int j = 0; j < array.GetLength(1); j++)
		{
			copy_array[i,j] = array[i,j];
		}
	}
	return copy_array;
}
int [,] matrix = {{1,2},{3,4},{5,6}};

Copy (matrix);
for(int i = 0; i < matrix.GetLength(0); i++)
	{
		for(int j = 0; j < matrix.GetLength(1); j++)
		{
			Console.Write(matrix[i,j]);
		}
		Console.WriteLine("");
	}
*/