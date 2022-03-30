// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
void NumberEvenArray(int N)
{
    int[] array = new int[N];
    int counter = 0;
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if(array[i]%2 == 0) {counter++;}
    }
    Console.WriteLine("Количество четных чисел в представленном массиве " + "{0}", string.Join(", ", array) + " равно " + counter);
}

Console.Write("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
NumberEvenArray(N);
*/


// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
void SummOddPositionArray(int N)
{
    int[] array = new int[N];
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 100);
        if(i%2 > 0) {sum = sum + array[i];}
    }
    Console.WriteLine("Сумма элементов, стоящих на нечетных позициях в представленном массиве " + "{0}", string.Join(", ", array) + " равна " + sum);
}

Console.Write("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
SummOddPositionArray(N);
*/

// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
void MaxMinDifferent (double[] array)
{
    int maxArrayIndex = 1;
    int minArrayIndex = 0;
    if(array[0] >= array[1]) 
    {
        maxArrayIndex = 0;
        minArrayIndex = 1;
    }
    for(int i = 2; i < array.Length; i++)
    {
        if(array[i] > array[maxArrayIndex]) {maxArrayIndex = i;}
        if(array[i] < array[minArrayIndex]) {minArrayIndex = i;}
    }
    double diff = array[maxArrayIndex] - array[minArrayIndex];
    Console.WriteLine("Разница между максимальным и минимальным элементами в представленном массиве " + "{0}", string.Join(", ", array) + " равна " + diff);
}

double[] testArray = {1,1,1,2,2,2,3,3,3,4,4,4,5,6,7,8,9,9,9};
MaxMinDifferent(testArray);
*/