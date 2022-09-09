Start();

void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        System.Console.WriteLine("47) Задача 47. Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.");
        System.Console.WriteLine("50) Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
        System.Console.WriteLine("52) Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
        System.Console.WriteLine("0) Выход");

        int numTask = InputNumber("Введите номер задачи: ");

        switch (numTask)
        {
            case 0: return; break;
            case 47:

                int m = InputNumber("Введите количество строк массива: ");
                int n = InputNumber("Введите колтчество столбцов массива: ");

                double[,] matrix = new double[m, n];

                FillArrayDouble(matrix);

                PrintArrayDouble(matrix);

                break;

            case 50:

                int[,] matrix50 = new int[5, 6];

                FillArray(matrix50, 1, 10);

                PrintArray(matrix50);

                System.Console.WriteLine("Нумерация строк и столбцов массива начнается с 0");

                int row = InputNumber("Введите номер строки массива: ");
                int colum = InputNumber("Введите номер столбца массива: ");

                CheckElement(matrix50, row, colum);

                break;

            case 52:

                int[,] matrix52 = new int[3, 4];

                FillArray(matrix52, 1, 10);

                PrintArray(matrix52);

                AverageColums(matrix52);

                break;

            default: System.Console.WriteLine("Вводите номера задач внимательнее!!!"); break;
        }
    }
}

int InputNumber(string text) // Считывание числа из консоли. 
{
    System.Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void FillArrayDouble(double[,] matr) // Заполнение двумерного массива вещественными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            double tail = new Random().NextDouble();
            matr[i, j] = new Random().Next(1, 11) + tail;
        }
    }
}

void PrintArrayDouble(double[,] matr) // Вывод двумерного массива вещественных чисел на экран
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]:f2} ");
        }

        System.Console.WriteLine();
    }
}

void FillArray(int[,] matr, int min, int max) // Заполнение двумерного массива случайными целыми числами
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

void PrintArray(int[,] matr) // Вывод двумерного массива целых чисел на экран
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }

        System.Console.WriteLine();
    }
}

void CheckElement(int[,] matr, int rowCheck, int columCheck)
{
    if ((rowCheck < matr.GetLength(0)) && (columCheck < matr.GetLength(1)))
    {
        System.Console.WriteLine($"Элемент в {rowCheck} строке и {columCheck} столбце = {matr[rowCheck, columCheck]}");
    }
    else System.Console.WriteLine($"Такого элемента нет!");
}

void AverageColums(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        double summ = 0;

        for (int j = 0; j < matr.GetLength(0); j++)
        {
            summ += matr[j, i];
        }

        System.Console.WriteLine($"Среднее арифметическое {i} колонки = {summ / matr.GetLength(0):f2}");
    }
}