// Задача 63: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от 1 до N.

// using System;
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите значение N: ");
//         int n = int.Parse(Console.ReadLine());

//         PrintNumbers(1, n);
//     }

//     static void PrintNumbers(int start, int end)
//     {
//         if (start <= end)
//         {
//             Console.Write(start + " ");
//             PrintNumbers(start + 1, end);
//         }
//     }
// }

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите значение M: ");
//         int m = int.Parse(Console.ReadLine());

//         Console.Write("Введите значение N: ");
//         int n = int.Parse(Console.ReadLine());

//         PrintNumbers(m, n);
//     }

//     static void PrintNumbers(int start, int end)
//     {
//         if (start <= end)
//         {
//             Console.Write(start + " ");
//             PrintNumbers(start + 1, end);
//         }
//     }
// }

// Задача 67: Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр.
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите число: ");
//         int number = int.Parse(Console.ReadLine());

//         int sum = SumOfDigits(number);

//         Console.WriteLine("Сумма цифр числа: " + sum);
//     }

//     static int SumOfDigits(int number)
//     {
//         if (number < 10)
//         {
//             return number;
//         }
//         else
//         {
//             int lastDigit = number % 10;
//             int remainingDigits = number / 10;
//             return lastDigit + SumOfDigits(remainingDigits);
//         }
//     }
// }

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и 
// возводит число А в целую степень B с помощью рекурсии.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите степень B: ");
        int b = int.Parse(Console.ReadLine());

        int result = Power(a, b);

        Console.WriteLine("{0} в степени {1} = {2}", a, b, result);
    }

    static int Power(int a, int b)
    {
        if (b == 0)
        {
            return 1;
        }
        else if (b == 1)
        {
            return a;
        }
        else if (b % 2 == 0)
        {
            int halfPower = Power(a, b / 2);
            return halfPower * halfPower;
        }
        else
        {
            int halfPower = Power(a, (b - 1) / 2);
            return halfPower * halfPower * a;
        }
    }
}
