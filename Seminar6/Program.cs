// Задача дз 41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите количество чисел: ");
int m = int.Parse(Console.ReadLine());

int[] nums = new int[m];

int count = 0; //счетчик чисел больше 0

for (int i = 0; i < m; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    int num = int.Parse(Console.ReadLine());
    nums[i] = num;
    if (num > 0)
    {
        count++;
    }
}
Console.WriteLine($"Массив: {string.Join(", ", nums)}");
Console.WriteLine($"Количество чисел больше 0: {count}");

//  Задача ДЗ 43 Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine());

Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения: ({x}, {y})");
