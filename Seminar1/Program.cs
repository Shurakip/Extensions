//                                          Задача 1
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
   Console.WriteLine($"{num1} больше {num2}");
else
    Console.WriteLine($"{num2} больше {num1}");

//                                          Задача 2
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine());

int max = num1;

if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}
Console.WriteLine("Максимальное число: " +max);

//                                          Задача 3
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
    Console.WriteLine($"Число {num} четное");
else
    Console.WriteLine($"Число {num} нечетное");

//                                          Задача 4
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Четные числа от одного до {num}:");

for (int i = 1; i < num; i++)
    
    if (i % 2 == 0)
  
    Console.Write(i + " ");
