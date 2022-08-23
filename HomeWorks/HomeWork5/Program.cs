//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int [] RandomMassive ()
{
    int[] arr = new int[6]; 
    Random rand = new Random (); 
    for (int massive_index = 0; massive_index < arr.Length; massive_index++)
      {
          arr[massive_index] = rand.Next(1,1000);
          Console.WriteLine(arr[massive_index]);
      }

return arr;
}

void CountEvenNumbers (int [] arra)
{
    int count = 0;
    for (int i = 0; i < arra.Length; i++)
    {
        if (arra [i] %2 ==0)
        count = count + 1;
    }
Console.Write ($"Sum of even numbers is {count}");
}

int [] array = RandomMassive();
CountEvenNumbers(array);
*/

//Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int [] RandomMassive ()
{
    int[] arr = new int[6];
    Random rand = new Random (); 
    for (int massive_index = 0; massive_index < arr.Length; massive_index++)
      {
          arr[massive_index] = rand.Next(100);
          Console.WriteLine(arr[massive_index]);
      }

return arr;
}

void FindSumofOddElements (int [] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (i %2 >0)
        sum += arr [i];
    }
Console.Write ($"Sum of odd numbers is {sum}");
}
int [] array = (RandomMassive());
FindSumofOddElements(array);

//Console.WriteLine (RandomMassive ());
*/

//Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
float [] RandomMassive ()
{
    float [] arr = new float[6]; 
    Random rand = new Random (); 
    for (int massive_index = 0; massive_index < arr.Length; massive_index++)
      {
          arr[massive_index] = rand.Next();
          Console.WriteLine(arr[massive_index]);
      }

//float max = arr.Max ();
//float min = arr.Min ();
return arr;

}
//Console.WriteLine(RandomMassive ());

void FindDifferenceBetweenMaxAndMin (float [] array)
{
float max = array.Max ();
float min = array.Min ();
float result = max - min;
Console.Write ($"The difference between max and min is {result}");

}

float [] final_array = RandomMassive();
FindDifferenceBetweenMaxAndMin(final_array);









