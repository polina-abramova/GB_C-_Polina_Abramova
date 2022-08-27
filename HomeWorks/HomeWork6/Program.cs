// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int CountPositive (int [] arr)
{
    int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                count = 1 + count;
            }
        }
    return count;
}

Console.Write ("Введите любое количество целых чисел через пробел: ");

int[] array_from_string = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); //преобразуем стринговый массив в массив чисел

int result = CountPositive (array_from_string);

Console.WriteLine ($"Вы ввели {result} положительных чис-ел (-а)!");

*/
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void FindCrossPoint (double k1, double b1, double k2, double b2)
{
    double x = (b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;
    x = Math.Round(x, 1);
    y = Math.Round(y, 1);
    Console.WriteLine ($"Прямые пересекаются в точке c координатами ({x}; {y})");
}

Console.Write("Задайте k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Задайте b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Задайте k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Задайте b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

FindCrossPoint (k1, b1, k2, b2);
