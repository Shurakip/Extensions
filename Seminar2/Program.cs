//                                                  Задача 1
Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
int secondDigit = (num / 10) % 10;

Console.WriteLine("Вторая цифра числа: {0}", secondDigit);

//                                                  Задача 2
//  int ThirdDigit(int number)
//         {
//             int result = -1;
//             if (number >= 100)
//             {
//                 while (number > 999)
//                 {
//                     number = number / 10;
//                 }
//                 result = number % 10;
//             }
//             return result; 
//         }
//         Console.Write("Введите число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
 
// if (ThirdDigit(number1) == -1)
// Console.WriteLine("третьей цифры нет");
// else
// Console.WriteLine($"Третья цифра {ThirdDigit(number1)}");

// //                                                      Задача 3
// Console.Write("Введите цифру дня недели (1-7): ");
// int num = Convert.ToInt32(Console.ReadLine());
//     if (num == 6 || num == 7)
//         Console.WriteLine ("Это выходной");
//     else
//         Console.WriteLine ("Это рабочий!");