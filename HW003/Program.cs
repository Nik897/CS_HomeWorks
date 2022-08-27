// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void palindrome()
// {
//     Console.Write("Введите 5-зачное число: ");
//     int number = int.Parse(Console.ReadLine());

//     if ((number >= 10000) && (number < 100000))
//     {
//         if (number / 10000 == number % 10)
//         {
//             int temp = number;

//             temp %= 10000;
//             temp /= 10;

//             if (temp / 100 == temp % 10)
//             {
//                 Console.WriteLine($"{number} является палиндромом");
//             }
//             else
//             {
//                 Console.WriteLine($"{number} НЕ является палиндромом");
//             }          
//         }
//         else
//         {
//             Console.WriteLine($"{number} НЕ является палиндромом");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Чмсло не 5-значное!!!");
//     }
// }

// palindrome();

// --------------------------------------------------------------------------------------

// Универсальный вариант на проверку палиндрома для чмсел и строк:

void polindromeString()
{
  Console.Write("Введите строку: ");
  string str = Console.ReadLine();

  int length = str.Length;

  int count = length / 2;

  bool flag = true;

  for (int i = 0; i < count; i++)
  {
    if (str[i] != str[length -1 -i])
    {
      flag = false;
      break;      
    }
  }

  if (flag ) Console.WriteLine($"Строка {str} - палиндром");
  else Console.WriteLine($"Строка {str} - НЕ палиндром"); 
}

polindromeString();

// --------------------------------------------------------------------------------------

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// void DistanceAB()
// {
//     Console.Write("Введите x1 ");
//     int Ax = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Введите y1 ");
//     int Ay = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Введите z1 ");
//     int Az = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Введите x2 ");
//     int Bx = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Введите y2 ");
//     int By = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Введите z2 ");
//     int Bz = Convert.ToInt32(Console.ReadLine());    

//     double result = Math.Sqrt( Math.Pow( (Bx - Ax), 2) + Math.Pow((By - Ay),2 ) + Math.Pow((Bz - Az), 2));
//     Console.WriteLine($"{result:f2}");

// }

// DistanceAB();

// --------------------------------------------------------------------------------------

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void cubicNumber()
// {
//       Console.Write("Введите число: ");
//       int N = Convert.ToInt32(Console.ReadLine());

//       for (int i = 1; i <= N; i++)
//       {
//         Console.Write($"{Math.Pow(i, 3)} ");       
//       }
// }

// cubicNumber();