// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] createRndArray(int N, int min, int max) // Создаем массив длиной N из целых чисел в диапазоне [min, max]
// {
//     int[] array = new int[N];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void printArray(int[] array) // Выводим массив на экран
// {
//     System.Console.WriteLine(string.Join(" ", array));
// }

// int inputNumber(string text) // Считывание числа из консоли. 
// {
//     System.Console.Write(text);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }

// int evenCount(int[] array) // Считаем количество четных элементов массива
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) count++;
//     }
//     return count;
// }

// int[] myArray;

// int lenArray = inputNumber("Введите длину массива: ");

// myArray = createRndArray(lenArray, 100, 1000);

// printArray(myArray);

// System.Console.WriteLine($"Количество четных элементов в массиве = {evenCount(myArray)}");

// ------------------------------------------------------------------------------------

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] createRndArray(int N, int min, int max) // Создаем массив длиной N из целых чисел в диапазоне [min, max]
// {
//     int[] array = new int[N];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void printArray(int[] array) // Выводим массив на экран
// {
//     System.Console.WriteLine(string.Join(" ", array));
// }

// int inputNumber(string text) // Считывание числа из консоли. 
// {
//     System.Console.Write(text);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }

// int oddSum(int[] array) // Считаем сумму элементов на нечетных позициях массива
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i += 2)
//     {
//         sum += array[i];
//     }
//     return sum;
// }

// int[] myArray;

// int lenArray = inputNumber("Введите длину массива: ");

// myArray = createRndArray(lenArray, -100, 100);

// printArray(myArray);

// System.Console.WriteLine($"Сумма элементов на нечетных позициях = {oddSum(myArray)}");

// -------------------------------------------------------------------------------

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int[] createRndArray(int N, int min, int max) // Создаем массив длиной N из целых чисел в диапазоне [min, max]
// {
//     int[] array = new int[N];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void printArray(int[] array) // Выводим массив на экран
// {
//     System.Console.WriteLine(string.Join(" ", array));
// }

// int inputNumber(string text) // Считывание числа из консоли. 
// {
//     System.Console.Write(text);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }

// int[] newArray(int[] array) // Произведение пар массива
// {
//     int newLen = array.Length / 2;

//     int[] newArr = new int[newLen];

//     for (int i = 0; i < newLen; i++)
//     {
//         newArr[i] = array[i] * array[array.Length - 1 - i];
//     }

//     if (array.Length % 2 != 0) // Если длина массива нечетное число, то размер нового массива увеличиваем на 1 и добавляем последний элемент
//     {
//         Array.Resize (ref newArr, newArr.Length +1); 
//         newArr[newLen] = array[newLen];
//     }

//     return newArr;
// }

// int[] myArray;

// int lenArray = inputNumber("Введите длину массива: ");

// myArray = createRndArray(lenArray, 1, 10);

// printArray(myArray);

// int[] myNewArray;

// myNewArray = newArray(myArray);

// printArray(myNewArray);

// ---------------------------------------------------------------------------------

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] createRndArray(int N, int min, int max) // Создаем массив длиной N из целых чисел в диапазоне [min, max]
{
    double[] array = new double[N];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void printArray(double[] array) // Выводим массив на экран
{
    System.Console.WriteLine(string.Join(" ", array));
}

int inputNumber(string text) // Считывание числа из консоли. 
{
    System.Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double maxMinusMin(double[] array) // Счмтаем разницу между максимальным и минимальным элементом
{
    double result =0, 
        min = array[0], max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min) min = array[i];
            if (array[i] > max) max = array[i];
        }

        return result = max - min;
}

double[] myArray;

int lenArray = inputNumber("Введите длину массива: ");

myArray = createRndArray(lenArray, -10, 10);

printArray(myArray);

System.Console.WriteLine($"Разница между минимальным и максимальным элементами равна: {maxMinusMin(myArray)}");