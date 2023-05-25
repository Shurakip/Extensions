// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N.
using System;

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

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите значение M: ");
//         int m = int.Parse(Console.ReadLine());

//         Console.Write("Введите значение N: ");
//         int n = int.Parse(Console.ReadLine());

//         int sum = SumOfNumbers(m, n);

//         Console.WriteLine("Сумма натуральных чисел в промежутке [{0}, {1}] равна {2}", m, n, sum);
//     }

//     static int SumOfNumbers(int m, int n)
//     {
//         if (m == n)
//         {
//             return m;
//         }
//         else if (m < n)
//         {
//             return m + SumOfNumbers(m + 1, n);
//         }
//         else
//         {
//             return n + SumOfNumbers(m, n + 1);
//         }
//     }
// }

// Задача 68: Напишите программу вычисления функции Аккермана с помощью 
// рекурсии. Даны два неотрицательных числа m и n. 

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите число n: ");
        int n = int.Parse(Console.ReadLine());

        int result = Ackermann(m, n);

        Console.WriteLine("Результат функции Аккермана для чисел {0} и {1} равен {2}", m, n, result);
    }

    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}
