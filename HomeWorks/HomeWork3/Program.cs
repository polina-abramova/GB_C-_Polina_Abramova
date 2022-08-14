//Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool IsPalindrom (int number)
{

    int first_digit = number / 10000; 
    int second_digit = (number / 1000)%10;
    int forth_digit = (number % 100)/10;
    int figth_digit = number % 10;
    // Console.WriteLine (first_digit);
    // Console.WriteLine (second_digit);
    // Console.WriteLine (forth_digit);
    // Console.WriteLine (figth_digit);
    
if ((first_digit == figth_digit) && (second_digit == forth_digit)) return true;
else 
return false; 
}

Console.Write ("Imput your 5digit number ");
int n1 = Convert.ToInt32(Console.ReadLine ());

bool answer = IsPalindrom (n1);
Console.WriteLine (answer);
*/

//Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double FindtheWay (double xA, double yA, double zA, double xB, double yB, double zB)
{
double x = xB - xA;
double y = yB - yA;
double z = zB - zA;
double ab_quad = Math.Pow(x,2) + Math.Pow(y,2) + Math.Pow(z,2);
double way = Math.Sqrt(ab_quad);
return way;
}
Console.Write ("Imput xA ");
double x_a = Convert.ToDouble(Console.ReadLine ());

Console.Write ("Imput yA ");
double y_a = Convert.ToDouble(Console.ReadLine ());

Console.Write ("Imput zA ");
double z_a = Convert.ToDouble(Console.ReadLine ());

Console.Write ("Imput xB ");
double x_b = Convert.ToDouble(Console.ReadLine ());

Console.Write ("Imput yB ");
double y_b = Convert.ToDouble(Console.ReadLine ());

Console.Write ("Imput zB ");
double z_b = Convert.ToDouble(Console.ReadLine ());

double result = FindtheWay (x_a, y_a, z_a, x_b, y_b, z_b);

Console.Write ($"ab quad = {result}");
*/

//Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube (int n)
{
int current = 1;

    while (current <= n) 
    {
        Console.Write (Math.Pow(current,3) + " "); 
        current ++;
    }
    
}

Console.Write ("Imput your number ");
int n1 = Convert.ToInt32(Console.ReadLine ());

Cube (n1);
*/

