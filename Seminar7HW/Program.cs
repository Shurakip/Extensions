// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Введите m массива: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите n массива: ");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];
Random rand = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = rand.NextDouble() * 200 - 100;
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{array[i, j]:F2}\t");
    }
    Console.WriteLine();
}


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Write("Введите m массива: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите n массива: ");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];
Random rand = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = rand.NextDouble() * 200 - 100;
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{array[i, j]:F2}\t");
    }
    Console.WriteLine();
}


Console.Write("Введите номер строки элемента: ");
int row = int.Parse(Console.ReadLine());

Console.Write("Введите номер столбца элемента: ");
int col = int.Parse(Console.ReadLine());

if (row >= 0 && row < m && col >= 0 && col < n)
{
    Console.WriteLine($"Значение элемента [{row}, {col}]: {array[row, col]:F2}");
}
else
{
    Console.WriteLine("Элемент с такими координатами не существует");
}

//  Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Write("Введите m массива: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите n массива: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элементов: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элементов: ");
int max = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];
Random rand = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
   {
    array[i, j] = rand.Next(min, max + 1);
   }
}
Console.WriteLine("Массив:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write("{0, 4}", array[i, j]);
    }
    Console.WriteLine();
}


Console.WriteLine("Среднее арифметическое элементов в столбцах:");
for (int j = 0; j < n; j++)
{
    double sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum += array[i, j];
    }
    double average = sum / m;
    Console.WriteLine("Столбец {0}: {1}", j + 1, average);
}
