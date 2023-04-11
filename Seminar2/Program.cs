//!!Первая задача!!
//Console.Write("Введите два числа через пробел");
//string[] input = Console.ReadLine().Split();
//
//int a = int.Parse(input[0]);
//int b = int.Parse(input[1]);
//
//if (b % a == 0)
//    Console.WriteLine($"{b} кратно {a}");
//else 
//    Console.WriteLine($"Остаток от деления {b} на {a}: {b % a}");
//                                                   !!вторая задача!!                    закомментарить сразу несколько строк - ctrl+/
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// if (num % 7 == 0 && num %23 == 0)
//     Console.WriteLine($"{num} кратно и 7 и 23");
// else 
//     Console.WriteLine($"{num} не кратно и 7 и 23");
//                                                  !!третья задача!!
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

double sqrt = Math.Sqrt(num2);

if (num1 == sqrt)
    Console.WriteLine($"{num1} является квадратом {num2}");
else
    Console.WriteLine($"{num1} является квадратом {num2}");