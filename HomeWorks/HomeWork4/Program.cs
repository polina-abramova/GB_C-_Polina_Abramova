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

//Задача 2. Принимает на вход число и выдает количество цифр в числе
/*

int FindNumberOfDigits (int number)
{

    int delitel = 10;
    int count = 0;

    for (int i =1 ; number>=1; i++)
    {
        number = number/delitel;
        count = i;
    }
    return count;

}
Console.WriteLine ("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = FindNumberOfDigits(a);
Console.WriteLine ($"The 1 number of digits in {a} is {result}");

*/
//Console.WriteLine ("Input integer number: ");
//int a = Convert.ToInt32(Console.ReadLine());
//int result = a%10;
//Console.WriteLine (result);
//Console.WriteLine (a/10);

int FindSumOfDigits (int number)
{
    int last_symbol = number%10;
    int current_number = number/10;
    int i = 1;
    int sum = 0;

    for (i=1; current_number > 0; i ++)
    {
        int pre_last_symbol = last_symbol%10;
        int pre_current_symbol = current_number/10;
        sum = sum + last_symbol;
    }
    return sum;
   
}

Console.WriteLine ("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = FindSumOfDigits (a);
Console.WriteLine ($"Sum of numbers in {a} is {result}.");


