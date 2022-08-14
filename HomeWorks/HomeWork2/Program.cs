// Задача 1. Программа принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int ShowSecondD (int number)
{
    int last2 = number % 100; // выделяем 2 последние цифры
    int secondn = last2 / 10; // получаем 2 цифру 

    return secondn;
}

Console.WriteLine ("Input threedigit number ") ;
int number1 = Convert.ToInt32(Console.ReadLine());

int result = ShowSecondD (number1);

Console.WriteLine ($"The second digit of {number1} is {result}") ;
*/




//Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.WriteLine ("Input number ");
string input1 = Console.ReadLine();

int num;
bool isNum = int.TryParse(input1, out num);

if(input1.Length>2 && isNum)
{
char result = input1[2];
Console.WriteLine ($"Третий знак вашего числа - это {result}");
}
else
{
   Console.WriteLine ("Ваше число имеет менее трех знаков или введено некорректное значение"); 
}
*/
//Задача 3. Программа принимает на вход цифру, обозначающую день недели и сообщает, является ли этот день выходным

bool IsHoliday (int number)
{
    if (number != 6 && number != 7)
    return false;
    else 
    return true;
}

Console.Write ("Imput number of day (from 1 to 7 where 1 is monday and 7 is sunday): ");
int n = Convert.ToInt32(Console.ReadLine());

bool holiday = IsHoliday(n);
Console.WriteLine (holiday);





