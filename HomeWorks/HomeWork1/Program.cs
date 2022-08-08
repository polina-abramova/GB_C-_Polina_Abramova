// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Input first number");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 > number_2)
    Console.WriteLine($"{number_1} > {number_2}");

else
Console.WriteLine ($"{number_2} > {number_1}");
*/

/*
//Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.WriteLine("Input first number");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number");
int number_2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input third number");
int number_3 = Convert.ToInt32(Console.ReadLine());

int[] arr = {number_1, number_2, number_3};

Console.WriteLine("Maximum number is " + arr.Max());
*/

/*
//Задача 3.Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Input your number");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2 == 0)
Console.WriteLine("Hey, it's even number");
else
Console.WriteLine("Hey, it's odd number");
*/

//Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Input your number");
int number = Convert.ToInt32(Console.ReadLine());
int current_number = 2;

while (current_number <= number)
{
    Console.Write (current_number + " ");
    current_number +=2; 
}

