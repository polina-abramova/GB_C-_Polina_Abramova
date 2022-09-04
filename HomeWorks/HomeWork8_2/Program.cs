//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int [,] CreateRandom2dArray (int m, int n, int minValue, int maxValue)
{
    int [,] NewArray = new int [m,n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            NewArray [i,j]= new Random().Next (minValue, maxValue +1);
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

int [,] SortLinesDescending (int [,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1) - 1; j++)
    {
        for (int x = 0; x < arr.GetLength(1) - 1; x++)
        {
            if (arr[i, x] < arr[i, x + 1])ми
                temp = arr[i, x];
                arr[i, x] = arr[i, x + 1];
                arr[i, x + 1] = temp;
            }
        }
    }
}
return arr;
}

Console.Write ("Input number of rows for your massive: ");
int m =Convert.ToInt32(Console.ReadLine());
Console.Write ("Input number of coloms for your massive: ");
int n =Convert.ToInt32(Console.ReadLine());
Console.Write ("Input minimum for your massive: ");
int min =Convert.ToInt32(Console.ReadLine());
Console.Write ("Input maximum for your massive: ");
int max =Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Исходный массив: ");
int [,] myArray = CreateRandom2dArray (m,n, min, max);
Show2dArray (myArray);
Console.WriteLine ("Отсортированный массив: ");
int [,] sortedArray = SortLinesDescending (myArray);
Show2dArray(sortedArray);
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int [,] CreateRandom2dArray (int m, int n, int minValue, int maxValue)
{
    int [,] NewArray = new int [m,n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            NewArray [i,j]= new Random().Next (minValue, maxValue +1);
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

int FindSumfromLine (int[,] array, int i) //находим сумму элементов в каждой строке
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

void FindMinSumLine (int [,] array) // находим строку с наименьшей суммой
{
    int minSumLine = 0;
    int sumLine = FindSumfromLine(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
        {
            int tempSumLine = FindSumfromLine(array, i);
            if (sumLine > tempSumLine)
                {
                    sumLine = tempSumLine;
                    minSumLine = i;
                }
        }
    Console.WriteLine($"Номер строки с наименьшей суммой: {minSumLine+1}. Сумма элементов = {sumLine}.");
}

Console.Write ("Input number of rows for your massive: ");
int m =Convert.ToInt32(Console.ReadLine());
Console.Write ("Input number of coloms for your massive: ");
int n =Convert.ToInt32(Console.ReadLine());
Console.Write ("Input minimum for your massive: ");
int min =Convert.ToInt32(Console.ReadLine());
Console.Write ("Input maximum for your massive: ");
int max =Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Исходный массив: ");
int [,] myArray = CreateRandom2dArray (m,n, min, max);
Show2dArray (myArray);
FindMinSumLine (myArray);
*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int [,] CreateRandomMatrix (int x, int minValue, int maxValue)
{
    int [,] NewArray = new int [x,x];

    for (int i = 0; i < x; i++)
        for (int j = 0; j < x; j++)
            NewArray [i,j]= new Random().Next (minValue, maxValue +1);
    return NewArray;
}

void ShowMyMatrix (int [,] array)
{
    for (int i=0; i<array.GetLength (0); i++)
    {
        for (int j=0; j<array.GetLength (1); j++)
            Console.Write (array [i,j] + " ");

        Console.WriteLine();
    }

}

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

Console.Write ("Input size for your matriсes: ");
int x =Convert.ToInt32(Console.ReadLine());
Console.Write ("Input minimum for your matriсes: ");
int min =Convert.ToInt32(Console.ReadLine());
Console.Write ("Input maximum for your matriсes: ");
int max =Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("The first matrix is:");
int [,] myMatrixA = CreateRandomMatrix (x, min, max);
ShowMyMatrix (myMatrixA);

Console.WriteLine ("The second matrix is:");
int [,] myMatrixB = CreateRandomMatrix (x, min, max);
ShowMyMatrix (myMatrixB);

Console.WriteLine ("The result matrix is:");
int[,] resultMatrix = new int[x,x];
MultiplyMatrix(myMatrixA, myMatrixB, resultMatrix);
ShowMyMatrix (resultMatrix);
*/

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int [,,] CreateRandom3dArray (int m, int n, int z)

{
    int [,,] NewArray = new int [m, n, z]; //создаем трехмерный массив
    int [] ArrayForCheck = new int [m*n*z]; //создаем одномерный массив, куда записываем числа для проверки
    int check = 0; //переменная для проверки

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            for (int k = 0; k < z; k++)
            {           
                check = new Random().Next (10,100);
                while (ArrayForCheck.Contains(check))
                    {
                        check = new Random().Next (10,100);
                    }
            NewArray [i,j,k] = check;
            ArrayForCheck [k + j*z + i*z*n] = check; //чтобы индекс не затерся
            }
    return NewArray;
}

void Show3dArray (int [,,] array)
{
    for (int i=0; i<array.GetLength (0); i++)
    {
        for (int j=0; j<array.GetLength (1); j++)
        {
            for (int k=0; k<array.GetLength (2); k++)
            Console.Write (array [i,j,k] + " ");
            Console.WriteLine();
        }
    }
        Console.WriteLine();
}

void Show3dArrayIndex (int [,,] array)
{
    for (int i=0; i<array.GetLength (0); i++)
    {
        for (int j=0; j<array.GetLength (1); j++)
        {
            for (int k=0; k<array.GetLength (2); k++)
            Console.Write (array [i,j,k] + ($" ({i}, {j}, {k})") + " ");
            Console.WriteLine();
        }
    }
        Console.WriteLine();

}

Console.WriteLine ("Your 3D-massive is:");
int [,,] myArray = CreateRandom3dArray (2,2,2);
Show3dArray (myArray);
Console.WriteLine ("Your 3D-massive with indexes is:");
Show3dArrayIndex (myArray);
*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
int [,] SpiralMassive ()
{
int n = 4;
int[,] spiralMassive = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= spiralMassive.GetLength(0) * spiralMassive.GetLength(1))
{
  spiralMassive[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < spiralMassive.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= spiralMassive.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > spiralMassive.GetLength(1) - 1)
    j--;
  else
    i--;
}
return spiralMassive;

}


void ShowSpiralMassive (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} "); // числа < 10 с пробелами с двух сторон для красивого представления

      else Console.Write($"{array[i,j]} "); //числа > 10 с пробелом с одной стороны
    }
    Console.WriteLine();
  }
}
int [,] myMassive = SpiralMassive ();
ShowSpiralMassive(myMassive);
