// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку 
// массива.
// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это 
// невозможно, программа должна вывести сообщение для 
// пользователя.
// class Program 
// { 
//     static void Main(string[] args) 
//     { 
//         // Запрашиваем у пользователя количество строк и столбцов 
//     Console.Write("Введите количество строк: "); 
//     int rows = int.Parse(Console.ReadLine()); 
//     Console.Write("Введите количество столбцов: "); 
//     int cols = int.Parse(Console.ReadLine()); 
//     // Создаем двумерный массив заданного размера 
//     int[,] matrix = new int[rows, cols]; 
    
//     // Заполняем массив случайными числами от 1 до 9 
//         Random random = new Random(); 
//     for (int i = 0; i < rows; i++) 
//         { for (int j = 0; j < cols; j++) 
//         { matrix[i, j] = random.Next(1, 10); } 
//         } // Выводим исходный массив на консоль 
        
//         Console.WriteLine("Исходный массив:"); 
//         PrintMatrix(matrix); 
//         // Меняем местами первую и последнюю строки 
//         SwapRows(matrix, 0, rows - 1); 
//         // Выводим измененный массив на консоль 
//         Console.WriteLine("Измененный массив:"); 
//         PrintMatrix(matrix); } 
//         // Метод для вывода двумерного массива на консоль 
//         static void PrintMatrix(int[,] matrix) 
//             { int rows = matrix.GetLength(0); 
//             int cols = matrix.GetLength(1); 
//             for (int i = 0; i < rows; i++) 
//                 { for (int j = 0; j < cols; j++) 
//                 { Console.Write(matrix[i, j] + " "); 
//                 } Console.WriteLine(); } 
//             } 
            
//             // Метод для обмена местами двух строк двумерного массива 
//     static void SwapRows(int[,] matrix, int row1, int row2) 
//         { int cols = matrix.GetLength(1); 
//         for (int i = 0; i < cols; i++) 
//             { 
//                 int temp = matrix[row1, i]; 
//                 matrix[row1, i] = matrix[row2, i]; 
//                 matrix[row2, i] = temp; 
//             } 
//         } 
// }

class Program
{
static void Main(string[] args) {
        // Запрашиваем у пользователя количество строк и столбцов
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int cols = int.Parse(Console.ReadLine());

        // Создаем двумерный массив заданного размера
        int[,] matrix = new int[rows, cols];

        // Заполняем массив случайными числами от 1 до 9
        Random random = new Random();
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                matrix[i, j] = random.Next(1, 10);
            }
        }

        // Выводим исходный массив на консоль
        Console.WriteLine("Исходный массив:");
        PrintMatrix(matrix);

        // Меняем местами строки и столбцы
        int[,] transposedMatrix;
        if (TryTranspose(matrix, out transposedMatrix)) {
            Console.WriteLine("Транспонированный массив:");
            PrintMatrix(transposedMatrix);
        } else {
            Console.WriteLine("Невозможно поменять строки на столбцы.");
        }
    }

    // Метод для вывода двумерного массива на консоль
    static void PrintMatrix(int[,] matrix) {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // Метод для транспонирования двумерного массива (меняет строки на столбцы)
    // Возвращает true, если операция выполнена успешно, и false, если невозможно поменять строки на столбцы
    static bool TryTranspose(int[,] matrix, out int[,] transposedMatrix) {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Если матрица не квадратная, то транспонировать ее невозможно
        if (rows != cols) {
            transposedMatrix = null;
            return false;
        }

        // Создаем новую матрицу для транспонированной матрицы
        transposedMatrix = new int[rows, cols];

        // Копируем элементы матрицы в транспонированную матрицу
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                transposedMatrix[j, i] = matrix[i, j];
            }
        }

        return true;
        }
}
