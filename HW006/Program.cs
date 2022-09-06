// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// System.Console.Write("Введите числа через пробел: ");

// string s = Console.ReadLine();

// int[] num = new int[s.Length];

// num = s.Split(" ").Select(Int32.Parse).ToArray();

// int count = 0;

// for (int i = 0; i < num.Length; i++)
// {
//     if (num[i] > 0) count++;
// }

// System.Console.WriteLine($"Чисел больше 0: {count}");

//-------------------------------------------------------------------------------

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double inputNumber(string text) // Считывание числа из консоли. 
{
    System.Console.Write(text);
    double number = double.Parse(Console.ReadLine());
    return number;
}

double b1 = inputNumber("Введите b1: ");
double k1 = inputNumber("Введите k1: ");
double b2 = inputNumber("Введите b2: ");
double k2 = inputNumber("Введите k2: ");

double x = (b2 - b1) / (k1 - k2);
double y = ((k1 * b2) - (k2 * b1)) / (k1 - k2);

System.Console.WriteLine($"Координаты пересечения двух прямых: ({x},{y})");


