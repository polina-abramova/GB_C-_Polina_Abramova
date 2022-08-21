//Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
double MakeDegree (double number_a, double number_b)
{
    double result_1 = 1;
    for (int i = 1; i <= number_b ; i++)
    {
       result_1 = result_1 * number_a; 
    }
    return result_1;

}

Console.WriteLine ("Input integer number_a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Input integer number_b: ");
double b = Convert.ToDouble(Console.ReadLine());
double result = MakeDegree(a,b);
Console.WriteLine ($"The degree of {a} is {result}");
*/

//Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int FindSumOfDigits (int number)
{
int sum = 0;

            while (number > 0)
            {
 
                sum = sum + number % 10;
                number = number /10;
 
            }

            return sum;
}
Console.WriteLine ("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = FindSumOfDigits (a);
Console.WriteLine ($"Sum of numbers is {result}.");
            
*/
//Задача 3.  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Array RandomMassive ()
{
    int[] arr = new int[8]; // объявляем массив, говорим, что в нем 8 элементов
    Random rand = new Random (); 
    for (int massive_index = 0; massive_index < arr.Length; massive_index++)
      {
          arr[massive_index] = rand.Next(); //максимальное значение элемента в массиве
          Console.WriteLine(arr[massive_index]);
      }

return arr;
}
Console.WriteLine (RandomMassive ());