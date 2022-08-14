// Task 1. Задача, которая выводит случайное число из отрезка [10,99] и показывает его наибольшую цифру

int FindBiggestDigit(int number)
{
    int ed = number % 10; //цифра из разряда единиц
    int dec = number / 10; //цифра из десятки
    int max;

    if (ed>dec)
        max = ed;
    
    else
        max = dec;

    return max; 
}

//Console.Write ("Random two-Digit number is" );

int randomNumber = new Random().Next(10,100);

int biggestDigit = FindBiggestDigit(randomNumber);

Console.WriteLine($"Biggest digit of {randomNumber} is {biggestDigit}");

*/

/*
//Задача 2.Программа выводит случайное 3-х значное число и удаляет вторую цифру
int Cutnumber (int number)
{
    int ed = number %10;
    int sot = number/100;

    int result = sot *10 + ed;
    return result;
}

int randomNumber = new Random().Next (100,1000);

int NewNumber = Cutnumber (randomNumber);
Console.WriteLine ($"New version of {randomNumber} is {NewNumber}");
*/

//Задача 3. Принимает на вход 2 числа и выводит, является ли число кратным первому. Если нет - остаток от деления
/*
void IsDivisionable (int num1, int num2)
{
    int reminder = num2 % num1;
    
    if (reminder == 0)
    {
        Console.WriteLine ($"{num2} is divisionable of {num1}");
    }

    else 
    {
        Console.WriteLine ($"{num2} is not divisionable of {num1}. Reminder is {reminder}");
    }
}

Console.Write ("Imput first number ");
int n1 = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Imput second number ");
int n2 = Convert.ToInt32(Console.ReadLine ());

IsDivisionable (n1,n2);

*/

//Задача 4. Принимает число, проверяет, кратно ли оно 7 И 23
bool IsDivis(int number)
{
    if (number % 7==0 && number % 23 == 0)
    return true ;
    else
    return false;
}

Console.Write ("Imput number ");
int n = Convert.ToInt32(Console.ReadLine());

bool IsDivision = IsDivis(n);
Console.WriteLine (IsDivision);