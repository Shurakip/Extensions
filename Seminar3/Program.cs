//                                                  Задача 1 
// Console.WriteLine("Введите номер четверти 1-4: ");
// int quarter = int.Parse(Console.ReadLine());

//     switch (quarter)
//     {
//         case 1:
//             System.Console.WriteLine("x от 1 до бесконечности, у от 1 до бесконечности.");
//             break;
    
//             case 2:
//             System.Console.WriteLine("x от -1 до -бесконечности, у от 1 до бесконечности.");
//             break;
            
//             case 3:
//             System.Console.WriteLine("x от -1 до -бесконечности, у от -1 до -бесконечности.");
//             break;

//             case 4:
//             System.Console.WriteLine("x от 1 до бесконечности, у от -1 до -бесконечности.");
//             break;
//             default:
    
//     Console.WriteLine("Некорректный номер четверти");
//         return;
//     }
//                                              Задача 2
// Console.WriteLine("Введите координаты первой точки в формате х,у: ");
// string input1 = Console.ReadLine();
// string[] splitInput1 = input1.Split(',');
// int x1 = int.Parse(splitInput1[0]);
// int y1 = int.Parse(splitInput1[1]);

// Console.WriteLine("Введите координаты второй точки в формате х,у: ");
// string input2 = Console.ReadLine();
// string[] splitInput2 = input2.Split(',');
// int x2 = int.Parse(splitInput2[0]);
// int y2 = int.Parse(splitInput2[1]);

// double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

// Console.WriteLine($"Расстояние между точками равно: {distance}");
                                            //  Задача 3
// Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine("Таблица квадратов чисел от 1 до " + n +":");
//     for (int i = 1; i <= n; i++)
//         Console.WriteLine(i + " * " + i + " = " + (i * i));

//                                                                  Задачи Домашнего задания
//                              Задача 1 (Палиндром)
// Console.WriteLine("Введите пятизначное число: ");
//  int num = Convert.ToInt32(Console.ReadLine());

//  int a = num / 10000;
//  int b = (num / 1000) % 10;
//  int c = (num / 100) % 10;
//  int d = (num / 10) % 10;
//  int e = num % 10;

//  if (a == e && b == d)
//     Console.WriteLine("Число является палиндромом!");
// else
//     Console.WriteLine("Число не является палиндромом!");

//                              Задача 2 Координаты двух точек
// Console.WriteLine("Введите координаты первой точки: ");

// Console.Write("x1 = ");
// double x1 = double.Parse(Console.ReadLine());

// Console.Write("y1 = ");
// double y1 = double.Parse(Console.ReadLine());

// Console.Write("z1 = ");
// double z1 = double.Parse(Console.ReadLine());

// Console.WriteLine("Введите координаты второй точки: ");

// Console.Write("x1 = ");
// double x2 = double.Parse(Console.ReadLine());

// Console.Write("y1 = ");
// double y2 = double.Parse(Console.ReadLine());

// Console.Write("z1 = ");
// double z2 = double.Parse(Console.ReadLine());

// double deltaX = x2 - x1;
// double deltaY = y2 - y1;
// double deltaZ = z2 - z1;

// double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);

// Console.WriteLine($"Расстояние между точками равно: {distance}");

//                                          Задача 3 кубы чисел
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Таблица кубов чисел от 1 до " + n +":");
    for (int i = 1; i <= n; i++)
        Console.WriteLine(i + " ^ " + i + " = " + (i * i * i));