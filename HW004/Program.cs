// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int DegreeOF(int number, int degree)
// {
//     int res = number;
//     for (int i = 2; i <= degree; i++)
//     {
//         res *= number;
//     }
//     return res;
// }

// Console.Write("Введите число: ");
// int A = int.Parse(Console.ReadLine());

// Console.Write("Введите степень: ");
// int B = int.Parse(Console.ReadLine());

// Console.WriteLine($"{A} ^ {B} = {DegreeOF(A, B)}");

// -----------------------------------------------------------------------------

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumOfDigits(int num)
// {
//     int res = 0;

//     while (num > 0)
//     {
//         res += num % 10;
//         num /=10;
//     }
//     return res;
// }

// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine());

// Console.Write($"Сумма цифр числа {N} = {SumOfDigits(N)}");

//--------------------------------------------------------------------------

// Задача 29: Напишите программу, которая задаёт массив из введенного числа и выводит их на экран.
// пользователь вводит число элементов в массиве и минимальное, и максимальное значение . надо заполнить 
// массив рандоными данными от минимального до максимального значение .И важное уточнениее , 
// делать все в методе который возвращает массив
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] ArrayRnd(int min, int max, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] arrayPrt)
{
    for (int i = 0; i < arrayPrt.Length; i++)
    {
        Console.Write($"{arrayPrt[i]} ");
    }
}

Console.Write("Введите длину массива: ");
int N = int.Parse(Console.ReadLine());

int[] Arr = new int[N];

Console.Write("Введите минимальный элемент массива: ");
int minArr = int.Parse(Console.ReadLine());

Console.Write("Введите максимальный массива: ");
int maxArr = int.Parse(Console.ReadLine());

if (minArr <= maxArr)
{
    int[] a;
    a = ArrayRnd(minArr, maxArr, Arr);
    PrintArray (a);
}
else Console.WriteLine("Некорректный ввод минимального и максимального элемента массива!");
