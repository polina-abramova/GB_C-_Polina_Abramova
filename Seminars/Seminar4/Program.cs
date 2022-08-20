// Задача 1. Программа принимает число, возвращает сумму чисел от 1 до этого числа
/*
int FindSum (int number)
{
    int sum = 0;
    for (int current = 1; current <= number ; current ++)
    {
        sum += current;
    }
    return sum;
}

Console.WriteLine ("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = FindSum (a);
Console.WriteLine ($"Sum of numbers from 1 to {a} is {result}.");
*/
//Задача 2. Принимает на вход число и выдает количество цифр в числе

/*
int FindNumberOfDigits (int number)
{
    //int delitel = 10;
    //int ostatok = number / delitel;

    int delitel = 10;
    int count=0;

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
Console.WriteLine ($"The number of digits in {a} is {result}");
*/

//Задача 3. Принимает на вход число, выдает произведение чисел от 1 до n
/*
int FindF (int number)
{
    int f = 1;
    for (int current = 1; current <= number; current ++)
    {
        f = f * current;
    }

    return f;

}
Console.WriteLine ("Input integer number for factorial: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = FindF(a);
Console.WriteLine ($"The factorial of {a} is {result}");
*/
//Задача 4. Выводит массив из 8 элементов, наполненных 0 и 1 в случайном порядке

Array RandomMassive ()
{
    int[] arr = new int[8]; // объявляем массив, говорим, что в нем 8 элементов
    Random rand = new Random (); //метод
    for (int massive_index = 0; massive_index < arr.Length; massive_index++)
      {
          arr[massive_index] = rand.Next(2); //максимальное значение элемента в массиве
          Console.WriteLine(arr[massive_index]);
      }

return arr;
}
Console.WriteLine (RandomMassive ());
