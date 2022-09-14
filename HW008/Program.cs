Start();

void Start()
{
    while (true)
    {
        System.Console.WriteLine("Нажмите <Enter>");
        Console.ReadLine();
        Console.Clear();

        System.Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
        System.Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
        System.Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
        System.Console.WriteLine("Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
        System.Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.");
        System.Console.WriteLine("0) Выход");

        int numTask = InputNumber("Введите номер задачи: ");

        switch (numTask)
        {
            case 0: return; break;

            case 54:

                int row54 = 4, col54 = 5;
                int min54 = 1, max54 = 11;

                int[,] matrix54 = new int[row54, col54];

                FillArray(matrix54, min54, max54);

                PrintArray(matrix54);

                SortForRows(matrix54);

                System.Console.WriteLine();

                PrintArray(matrix54);

                break;

            case 56:

                int row56 = 3, col56 = 4;
                int min56 = 1, max56 = 10;

                int[,] matrix56 = new int[row56, col56];

                FillArray(matrix56, min56, max56);

                PrintArray(matrix56);

                System.Console.WriteLine();

                System.Console.WriteLine($"Строка с наименьшей суииой элементов -  {SearchMinRow(matrix56)} (нумерация строк начинается с 0)");

                break;

            case 58:

                int[,] matrixA = { { 2, 4 }, { 3, 2 } };
                int[,] matrixB = { { 3, 4 }, { 3, 3 } };

                // Вариант с массивами [2,3] и [3,3]
                // int[,] matrixA = { { 2, 0, -1 }, { 0, -2, 2 } };
                // int[,] matrixB = { { 4, 1, 0 }, { 3, 2, 1 }, { 0, 1, 0 } };

                // Вариант с массивами [2,3] и [3,2]
                // int[,] matrixA = { { 2, 1, 1 }, { 3, 0, 1 } };
                // int[,] matrixB = { { 3, 1 }, { 2, 1 }, { 1, 0 } };

                if (matrixA.GetLength(1) == matrixB.GetLength(0))
                {

                    int rowC = matrixA.GetLength(0);
                    int colC = matrixB.GetLength(1);

                    int[,] matrixC = new int[rowC, colC];

                    matrixC = MultiplicateAB(matrixA, matrixB);

                    PrintArray(matrixC);
                }

                else System.Console.WriteLine("Произведение этих матриц невозможно!");

                break;

            case 60:

                int length = 2, width = 2, heigth = 2;

                int minValue = 10, maxValue = 100; // Минимальное и масимальное значение элементов массива

                int[,,] cube = new int[length, width, heigth];

                int lengthUnic = length * width * heigth;

                int[] unicNumbers = new int[lengthUnic];

                unicNumbers = GenerateUnicNumber(minValue, maxValue, lengthUnic);

                FillCube(cube, length, width, heigth, unicNumbers);

                break;

            case 62:

                int N = 4, M = 4;

                int[,] spiralArray = new int[N, M];

                FillSpiral(spiralArray);

                PrintArrayd2(spiralArray);

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

void SortForRows(int[,] matr) // Сортировка строк массива по убыванию
{
    int row = matr.GetLength(0);
    int col = matr.GetLength(1);
    int temp = 0;

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < col; k++)
            {
                if (matr[i, j] >= matr[i, k])
                {
                    temp = matr[i, j];
                    matr[i, j] = matr[i, k];
                    matr[i, k] = temp;
                }
            }
        }
    }
}

int SearchMinRow(int[,] matr) // Поиск строки с минимальной суммой элементов
{
    int row = matr.GetLength(0);
    int col = matr.GetLength(1);

    int minIndexRow = 0, minSum = 100000;

    int sumRow;

    for (int i = 0; i < row; i++)
    {
        sumRow = 0;

        for (int j = 0; j < col; j++)
        {
            sumRow += matr[i, j];
        }

        if (sumRow < minSum)
        {
            minSum = sumRow;
            minIndexRow = i;
        }

    }

    return minIndexRow;
}

int[,] MultiplicateAB(int[,] matrA, int[,] matrB) // Произведение двух массивов
{
    int rC = matrA.GetLength(0);
    int cC = matrB.GetLength(1);

    int[,] matrC = new int[rC, cC];

    for (int i = 0; i < rC; i++)
    {
        for (int j = 0; j < cC; j++)
        {
            for (int k = 0; k < matrA.GetLength(1); k++)
            {
                matrC[i, j] += matrA[i, k] * matrB[k, j];
            }
        }
    }

    return matrC;
}

void FillCube(int[,,] cubeLocal, int len, int wi, int hei, int[] sourceArray) // Заролняем трехмерный массив
{
    int count = 0;

    for (int i = 0; i < len; i++)
    {
        for (int j = 0; j < wi; j++)
        {
            for (int k = 0; k < hei; k++)
            {
                cubeLocal[i, j, k] = sourceArray[count];
                System.Console.Write($"{cubeLocal[i, j, k]} ({i}, {j}, {k})  ");
                count++;
            }

            System.Console.WriteLine();
        }
    }
}

int[] GenerateUnicNumber(int minVal, int maxVal, int len) // генерируем уникальные числа и складываем в одномерный массив
{
    var random = new Random();

    int[] unicNum = new int[len];

    for (int i = 0; i < len; ++i)
    {
        bool flag;

        do
        {
            unicNum[i] = random.Next(minVal, maxVal);

            flag = true;

            for (int j = 0; j < i; ++j)
            {
                if (unicNum[i] == unicNum[j])
                {
                    flag = false;
                    break;
                }
            }
        } while (!flag);
    }
    return unicNum;
}

void FillSpiral(int[,] spiralArr) // Заполнение массива по спирали
{
    int nLocal = spiralArr.GetLength(0);
    int mLocal = spiralArr.GetLength(1);
    int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = mLocal;

    for (int i = 0; i < spiralArr.Length; i++)
    {
        spiralArr[row, col] = i + 1;

        if (--gran == 0)
        {
            gran = mLocal * (dirChanges % 2) + nLocal * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }

        col += dx;
        row += dy;
    }
}

void PrintArrayd2(int[,] matr) // Вывод двумерного массива целых чисел на экран с модификатором вывода :d2
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]:d2} ");
        }

        System.Console.WriteLine();
    }
}