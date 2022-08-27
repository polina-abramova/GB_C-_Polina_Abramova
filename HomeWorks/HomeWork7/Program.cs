//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double [,] CreateRandom2dArray (int m, int n, double minValue, double maxValue)
{
    double [,] NewArray = new double [m,n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        NewArray [i,j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    return NewArray;
}

void Show2dArray (double [,] array)
{
    for (int i=0; i<array.GetLength (0); i++)
    {
        for (int j=0; j<array.GetLength (1); j++)
            Console.Write (Math.Round (array [i,j],1) + " ");
        Console.WriteLine();
    }

}

Console.Write ("Input number of rows for your massive: ");
int m =Convert.ToInt32(Console.ReadLine());
Console.Write ("Input number of coloms for your massive: ");
int n =Convert.ToInt32(Console.ReadLine());
Console.Write ("Input minimum for your massive: ");
double min =Convert.ToDouble(Console.ReadLine());
Console.Write ("Input maximum for your massive: ");
double max =Convert.ToDouble(Console.ReadLine());

double [,] myArray = CreateRandom2dArray (m,n, min, max);
Show2dArray (myArray);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int [,] CreateRandom2dArray (int m, int n)
{
    int [,] NewArray = new int [m,n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            NewArray [i,j]= new Random().Next (1,100);
    return NewArray;
}

void Show2dArray (int [,] array)
{
    for (int i=0; i<array.GetLength (0); i++)
    {
        for (int j=0; j<array.GetLength (1); j++)
            Console.Write (array [i,j] + " ");

        Console.WriteLine();
    }

}

void CheckPosition (int [,] array, int m, int n)
{
if (n > array.GetLength(0) || m > array.GetLength(1))
{
    Console.WriteLine("Упс! Такого элемента в этом массиве нет :(");
}
else
{
    Console.WriteLine($"Элемент {n} строки и {m} столбца - это {array[n-1,m-1]}");
}
}

Console.Write ("Input number of rows for your massive: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input number of coloms for your massive: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2dArray (m,n);

Show2dArray (myArray);

Console.Write ("Input number of rows for check-up: ");
int m_check = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input number of coloms for check-up: ");
int n_check = Convert.ToInt32(Console.ReadLine());

CheckPosition (myArray, m_check, n_check);
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] CreateRandom2dArray (int m, int n)
{
    int [,] NewArray = new int [m,n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            NewArray [i,j]= new Random().Next (1,10);
    return NewArray;
}

void Show2dArray (int [,] array)
{
    for (int i=0; i<array.GetLength (0); i++)
    {
        for (int j=0; j<array.GetLength (1); j++)
            Console.Write (array [i,j] + " ");

        Console.WriteLine();
    }
}

void FindAvgfromColomn (int [,] array)
{
    //int avg = 0;
    int n = array.GetLength (0);
    
    for (int j=0; j<array.GetLength (1); j++)
    {
        double avg = 0; 
        avg = Math.Round (avg, 1);
        for (int i=0; i<array.GetLength (0); i++)
            {
                 avg = avg + array[i,j];
            }
            avg = avg / n;
    
    Console.Write(avg + "; ");
    }
}

Console.Write ("Input number of rows for your massive: ");
int m =Convert.ToInt32(Console.ReadLine());
Console.Write ("Input number of coloms for your massive: ");
int n =Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2dArray (m,n);
Show2dArray (myArray);
FindAvgfromColomn (myArray);
