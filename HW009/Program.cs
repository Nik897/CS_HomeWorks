Start();

void Start()
{
    while (true)
    {
        System.Console.WriteLine("Нажмите <Enter>");
        Console.ReadLine();
        Console.Clear();

        System.Console.WriteLine("Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");
        System.Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
        System.Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
        System.Console.WriteLine("0) Выход");

        int numTask = InputNumber("Введите номер задачи: ");

        switch (numTask)
        {
            case 0: return; break;

            case 64:

                System.Console.WriteLine("Первое число M должго быть больше 0 и меньше второго числа N");

                int M = InputNumber("Введите число M: ");
                int N = InputNumber("Введите число N: ");

                if ((M < N) && (M > 0)) PrintIntegers(M, N);
                else
                {
                    System.Console.WriteLine("Вводите числа внимательнее!!!");
                    Console.ReadLine();
                }
                break;

            case 66:

                System.Console.WriteLine("Первое число M должго быть больше 0 и меньше второго числа N");

                int M66 = InputNumber("Введите число M: ");
                int N66 = InputNumber("Введите число N: ");

                if ((M66 < N66) && (M66 > 0)) System.Console.WriteLine(SumIntegers(M66, N66));
                else
                {
                    System.Console.WriteLine("Вводите числа внимательнее!!!");
                    Console.ReadLine();
                }


                break;

            case 68:

                System.Console.WriteLine("Числа M и N должны быть неотрицательными");

                int M68 = InputNumber("Введите число M: ");
                int N68 = InputNumber("Введите число N: ");

                int res;

                if ((N68 >= 0) && (M68 >= 0)) 
                {
                    res = Akkerman(M68, N68);
                    System.Console.WriteLine($"A({M68}, {N68}) = {res}");
                }
                else
                {
                    System.Console.WriteLine("Вводите числа внимательнее!!!");
                    Console.ReadLine();
                }


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

int PrintIntegers(int m1, int n1)
{
    if (n1 == m1)
    {
        System.Console.WriteLine(m1);
        return m1;
    }
    System.Console.Write(m1 + " ");

    return PrintIntegers(m1 + 1, n1);
}

int SumIntegers(int m1, int n1)
{
    if (n1 == m1) return m1;

    return m1 + SumIntegers(m1 + 1, n1);
}

int Akkerman(int m1, int n1)
{
    if (m1 == 0) return n1 + 1;
    if (n1 == 0) return Akkerman (m1-1, 1);
    return Akkerman (m1 -1, Akkerman (m1, n1-1));
}