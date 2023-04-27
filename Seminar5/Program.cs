//                            Задача 1
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
void FillArray(int[] numbers, int minValue = -9, int maxValue = 9) //Метод заполнения массива
{
   maxValue++;
   Random rnd = new Random(); //  случайные числа

   for (int i = 0; i < numbers.Length; i++)
   {
   numbers[i] = rnd.Next(minValue, maxValue);
   }
}

void PrintArray(int[] numbers) // Метод печати массива
{
   for (int i = 0; i < numbers.Length; i++)
   {
    Console.Write($"{numbers[i]} ");
   }
   Console.WriteLine();
}

void FillArrayDouble(double[] numbers, double minValue = -9, double maxValue = 9) //Метод заполнения массива
{
   
   Random rnd = new Random(); //  случайные числа

   for (int i = 0; i < numbers.Length; i++)
   {
   double randomValue = minValue + (maxValue - minValue) * rnd.NextDouble();
   numbers[i] = randomValue;
   }
}

void PrintArrayDouble(double[] numbers) // Метод печати массива
{
   for (int i = 0; i < numbers.Length; i++)
   {
    Console.Write($"{numbers[i]} ");
   }
   Console.WriteLine();
}

int FindSumPosElements(int[] numbers) // найти положительные элементы
{
   int sum = 0;
   for (int i = 0; i < numbers.Length; i++)
   {
      if (numbers[i] > 0)
         sum += numbers[i];
   }
   return sum;
}

int FindSumNegElements(int[] numbers) //  найти отрицательные элементы
{
   int sum = 0;
   for (int i = 0; i < numbers.Length; i++)
   {
      if (numbers[i] < 0)
         sum += numbers[i];
   }
   return sum;
}

void GetPlus(int[] numbers)
{
   for (int i = 0; i < numbers.Length; i++)
   {
      numbers[i] *= -1;
     
   }
   
}

void FindElement(int[] numbers)
{
Console.WriteLine("Введите число");
   int num = Convert.ToInt32(Console.ReadLine());
   bool flag = false;
   for (int i = 0; i < numbers.Length; i++)
   {
      if (numbers[i] == num)
      {
         flag = true;
      }
   }
   if (flag) Console.WriteLine("Число есть в массиве");
   else Console.WriteLine("Числа нет в массиве");
}

int CountElementInSegment(int[] numbers)
{
   int count = 0;
   for (int i = 0; i < numbers.Length; i++)
   {
      if (numbers[i] >= 10 && numbers[i] <= 99) 
      {
         count++;
      }
   }
   return count;
}

// ----------------------------------------------------------------------------------------------------------------------
void Task1() //создание метода с именем Task1
{        //начало тела метода
   int size = 12; //размер (12)
   int[] numbers = new int[size]; // создается хранилище с размером size
   
   FillArray(numbers); // Вызываем метод заполнения массива
   PrintArray(numbers); //  Вызываем метод печати массива
   int summa = FindSumPosElements(numbers); //сумма положительных элементов
   Console.WriteLine($"Сумма положительных элементов массива = {summa}");
   
   Console.WriteLine($"Сумма отрицательных элементов массива = {FindSumNegElements(numbers)}");
}        //конец тела метода



//Task1();    //вызов метода. Без вызова он не будет работать. Это вызов решения первой задачи

//       Задача 2
//       Замена элементов массива: положительные на отрицательные и наоборот

void Task2() //Метод для решения второй задачи
{
   int size = 12; //размер (12)
   int[] numbers = new int[size]; // создается хранилище с размером size
   
   FillArray(numbers); // Вызываем метод заполнения массива
   PrintArray(numbers);
   GetPlus(numbers);
   PrintArray(numbers);

   
}

// Task2(); Решение второй задачи

//          Задача 3 найти есть ли заданное число в массиве
void Task3()
{
   int size = 12; //размер (12)
   int[] numbers = new int[size]; // создается хранилище с размером size
   
   FillArray(numbers); // Вызываем метод заполнения массива
   PrintArray(numbers);
   FindElement(numbers);
   
}
// Task3(); //  Решение третьей задачи

// Задача 4

void Task4()
{
   int size = 10; 
   int[] numbers = new int[size]; 
   
   FillArray(numbers, -30, 99); 
   PrintArray(numbers);
   
   Console.WriteLine($"В массиве {CountElementInSegment(numbers)} элементов из отрезка [10; 99]");

}

// Task4();

// Задача 5

void Task5()
{
   int size = 11; 
   int[] numbers = new int[size]; 
   
   FillArray(numbers, 0, 900); 
   PrintArray(numbers);

   int halfSize = numbers.Length/2;
   int lastIndex = numbers.Length - 1;
   for (int i = 0; i < halfSize; i++)
   {
      Console.WriteLine($"{numbers[i]} * {numbers[lastIndex - i]} = {numbers[i] * numbers[lastIndex - i]}");
   }

   if (numbers.Length % 2 == 1)
   {
      Console.WriteLine($"Число без пары - {numbers[halfSize]}");
   }
}
// Task5();
//                                  Задачи домашнего задания
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
void Dz1()
{
   int size = 10; 
   int[] numbers = new int[size]; 
   int count = 0;

   FillArray(numbers, 100, 999); 
   PrintArray(numbers);

   foreach (int num in numbers)
   {
      if (num % 2 == 0)
      {
         count++;
      }
   }

   Console.WriteLine("Количество четных чисел в массиве: " + count);
}

//Dz1();

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
void DZ2()
{
   int size = 10; 
   int[] numbers = new int[size]; 
   int sum = 0;

   FillArray(numbers, -100, 100); 
   PrintArray(numbers);

   for (int i = 1; i < numbers.Length; i += 2)
   {
      sum += numbers[i];
   }

   Console.WriteLine("Сумма элементов с нечетными индексами = " + sum);

}

//DZ2();

//   Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
void Dz3()
{
   int size = 5; 
   double[] numbers = new double[size]; 
   double min = numbers[0];
   double max = numbers[0];
  
   FillArrayDouble(numbers, -10, 10); 
   PrintArrayDouble(numbers);
   
   for (int i = 1; i < numbers.Length; i++)
   {
      if (numbers[i] < min)
      {
         min = numbers[i];
      }
      if (numbers[i] > max)
      {
         max = numbers[i];
      }
   }
   double diff = max - min;
   Console.WriteLine($"Разница между максимальным ({max}) и минимальным ({min}) элементами массива: {diff}");

}

Dz3();