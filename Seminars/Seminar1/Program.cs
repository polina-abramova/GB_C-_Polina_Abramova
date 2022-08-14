/*
//Задача 1. Возвести число в квадрат
Console.Write("Input a number ");
int num = Convert.ToInt32(Console.ReadLine ());

int quad = num * num;

//Console.WriteLine ("Your square of " + num + " is " + quad);
Console.WriteLine ($"Your square of {num} is {quad}");
*/

/*
//Задача 2. Проверить, является ли число 1 кваратом числа 2

Console.Write("Input first number ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number ");
int n2 = Convert.ToInt32(Console.ReadLine());

int quad2 = n2 * n2;
if (n1 == quad2)
    Console.WriteLine ("n1 is quad of n2");
else
    Console.WriteLine ("n1 is NOT quad of n2");
*/

//Задача 3. Принимает на вход одно число, а на выходе показывает все целые числа от отрицательной версии до положительной

/*
Console.WriteLine("Input positive number");
int number = Convert.ToInt32(Console.ReadLine());
int current_number = number * (-1);

while (current_number <= number)
{
    Console.Write(current_number +" ");
    current_number++;
}
*/

// Задача 4. Принимает трехзначное число, на выходе - последняя цифра этого числа

Console.WriteLine("Input integer threedigit number");
int number = Convert.ToInt32(Console.ReadLine());

int cut_number = number %10 ;

Console.Write ($"The last symbol of {number} is {cut_number}");