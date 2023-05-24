// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
class Program
{
    static void Main(string[] args)
    {
        // Запросить у пользователя количество строк и столбцов
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int cols = int.Parse(Console.ReadLine());

        // Создать двумерный массив
        int[,] arr = new int[rows, cols];

        // Заполнить массив случайными числами
        Random rnd = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arr[i, j] = rnd.Next(1, 100);
            }
        }

        // Вывести массив на экран
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("{0,4}", arr[i, j]);
            }
            Console.WriteLine();
        }

        // Упорядочить каждую строку по убыванию
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols - 1; j++)
            {
                for (int k = j + 1; k < cols; k++)
                {
                    if (arr[i, j] < arr[i, k])
                    {
                        int temp = arr[i, j];
                        arr[i, j] = arr[i, k];
                        arr[i, k] = temp;
                    }
                }
            }
        }

        // Вывести упорядоченный массив на экран
        Console.WriteLine("Упорядоченный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("{0,4}", arr[i, j]);
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите 
// программу, которая будет находить строку с наименьшей суммой элементов.
class Program
{
    static void Main(string[] args)
    {
        // Запросить у пользователя количество строк и столбцов
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int cols = int.Parse(Console.ReadLine());

        // Создать двумерный массив
        int[,] arr = new int[rows, cols];

        // Заполнить массив случайными числами
        Random rnd = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arr[i, j] = rnd.Next(1, 100);
            }
        }

        // Вывести массив на экран
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("{0,4}", arr[i, j]);
            }
            Console.WriteLine();
        }

        // Найти строку с наименьшей суммой элементов
        int minSumRow = 0;
        int minSum = int.MaxValue;

        for (int i = 0; i < rows; i++)
        {
            int rowSum = 0;

            for (int j = 0; j < cols; j++)
            {
                rowSum += arr[i, j];
            }

            if (rowSum < minSum)
            {
                minSum = rowSum;
                minSumRow = i;
            }
        }

        // Вывести строку с наименьшей суммой элементов на экран
        Console.WriteLine("Строка с наименьшей суммой элементов:");
        for (int j = 0; j < cols; j++)
        {
            Console.Write("{0,4}", arr[minSumRow, j]);
        }
        Console.WriteLine();

        Console.ReadLine();
    }
}


// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
class Program
{
    static void Main(string[] args)
    {
        // Создать первую матрицу
        int[,] matrix1 = new int[,]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // Создать вторую матрицу
        int[,] matrix2 = new int[,]
        {
            {9, 8, 7},
            {6, 5, 4},
            {3, 2, 1}
        };

        // Вывести первую матрицу на экран
        Console.WriteLine("Первая матрица:");
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                Console.Write("{0,4}", matrix1[i, j]);
            }
            Console.WriteLine();
        }

        // Вывести вторую матрицу на экран
        Console.WriteLine("Вторая матрица:");
        for (int i = 0; i < matrix2.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                Console.Write("{0,4}", matrix2[i, j]);
            }
            Console.WriteLine();
        }

        // Найти произведение матриц
        int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                int sum = 0;

                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }

                result[i, j] = sum;
            }
        }

        // Вывести произведение матриц на экран
        Console.WriteLine("Результат умножения матриц:");
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write("{0,4}", result[i, j]);
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}

// Задача 60: Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно выводить 
// массив, добавляя индексы каждого элемента.
class Program
{
    static void Main(string[] args)
    {
        // Создать трехмерный массив из неповторяющихся двузначных чисел
        int[,,] arr = new int[10, 10, 10];
        Random rnd = new Random();

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 10; k++)
                {
                    int num = rnd.Next(10, 100);

                    while (Array.IndexOf(arr, num) != -1)
                    {
                        num = rnd.Next(10, 100);
                    }

                    arr[i, j, k] = num;
                }
            }
        }

        // Вывести массив построчно с индексами каждого элемента
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 10; k++)
                {
                    Console.WriteLine("arr[{0}, {1}, {2}] = {3}", i, j, k, arr[i, j, k]);
                }
            }
        }

        Console.ReadLine();
    }
}

// Задача 62: Заполните спирально массив 4 на 4.
class Program
{
    static void Main(string[] args)
    {
        // Создать массив 4х4
        int[,] arr = new int[4, 4];

        // Заполнить массив по спирали
        int value = 1;
        int minRow = 0;
        int maxRow = 3;
        int minCol = 0;
        int maxCol = 3;

        while (value <= 16)
        {
            // Заполнить верхнюю строку
            for (int i = minCol; i <= maxCol; i++)
            {
                arr[minRow, i] = value;
                value++;
            }

            // Заполнить правый столбец
            for (int i = minRow + 1; i <= maxRow; i++)
            {
                arr[i, maxCol] = value;
                value++;
            }

            // Заполнить нижнюю строку
            for (int i = maxCol - 1; i >= minCol; i--)
            {
                arr[maxRow, i] = value;
                value++;
            }

            // Заполнить левый столбец
            for (int i = maxRow - 1; i >= minRow + 1; i--)
            {
                arr[i, minCol] = value;
                value++;
            }

            // Уменьшить границы массива
            minRow++;
            maxRow--;
            minCol++;
            maxCol--;
        }

        // Вывести массив на экран
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write("{0,4}", arr[i, j]);
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
