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
//                                              Задача 3
// Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine("Таблица квадратов чисел от 1 до " + n +":");
//     for (int i = 1; i <= n; i++)
//         Console.WriteLine(i + " * " + i + " = " + (i * i));