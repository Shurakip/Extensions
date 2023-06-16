class Program
{
    static void Main()
    {
        // Задание исходного массива
        string[] inputArray = {"a", "ab", "abc", "abcd", "abcde", "abcdef"};

        // Создание массива подходящих строк
        string[] resultArray = new string[inputArray.Length];
        int resultIndex = 0;

        // Проход по исходному массиву
        for (int i = 0; i < inputArray.Length; i++)
        {
            // Если строка подходит по длине, добавляем ее в результат
            if (inputArray[i].Length <= 3)
            {
                resultArray[resultIndex] = inputArray[i];
                resultIndex++;
            }
        }

        // Сокращаем размер массива до использованной длины
        Array.Resize(ref resultArray, resultIndex);

        // Вывод результатов
        Console.WriteLine("Входной массив: [{0}]", string.Join(", ", inputArray));
        Console.WriteLine("Выходной массив: [{0}]", string.Join(", ", resultArray));
        Console.ReadLine();
    }
}
