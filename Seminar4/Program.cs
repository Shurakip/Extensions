//                          Задача 1 сумма чисел от 1 до А
// System.Console.WriteLine("Введите число А: ");
//   int A = int.Parse(Console.ReadLine());

//   int getsum(int number)
//   {
//    int sum = 0;

//   for (int i = 1; i <= A; i++)

//   sum += i;
//   return sum;
// }

// System.Console.WriteLine($"Сумма чисел от 1 до {A}^ {getsum (A)}");

//                          Задача 2 подсчет цифр в числе
// System.Console.WriteLine("Введите число: ");
// string input = (Console.ReadLine());
// int count = 0;

// foreach (char c in input)
// {
//     if (Char.IsDigit(c))
//     {
//         count++;
//     }
// }
// System.Console.WriteLine("Количество цифр в числе: " + count);

//                          Задача 3 произведение чисел от 1 до N
// System.Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine());
// int result = 1;
 
// for (int i = 1; i <= n; i++ )
// {
//     result *= i;
// }
// Console.WriteLine($"Произведение чисел от 1 до {n} = {result}");

//                          Задача 4 массив из 8 элементов, заполненный нулями и единицами в случайном порядке
int [] array = new int [8];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0, 2); // задается рандом от 0 до 2 (два не включительно)
}
Console.WriteLine("Массив из 8 элементов: ");
foreach (int num in array)
{
    Console.Write($"{num}, ");
}
