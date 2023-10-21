Console.Clear();
//-------------------------------------------------------------------------------------------------------------------------------
// int Summ(int a, int b)
// {
//     if (b > 0)
//     return Summ(a + 1, b - 1);
//     else 
//     return a;
// }
// Console.WriteLine("Введите первое число:");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int numberB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Summ(numberA, numberB));
//-------------------------------------------------------------------------------------------------------------------------------
// **Задача 63:** Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
// string ShowNumbers(int number)
// {
//     if (number == 1)
//         return "1 ";
//     return ShowNumbers(number - 1) + $"{number} ";   
// }
// Console.WriteLine("Введите число:");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(ShowNumbers(numberA));
//-------------------------------------------------------------------------------------------------------------------------------
// **Задача 65:** Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"
// string ShowNumbers(int a, int b)
// {
//     if(a == b)
//         return $"{a} ";
//     return ShowNumbers(a, b - 1) + $"{b} ";
// }
// Console.WriteLine("Введите первое число:");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int numberB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(ShowNumbers(numberA, numberB));
//-------------------------------------------------------------------------------------------------------------------------------
// **Задача 67:** Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// int Summ(int a)
// {
//     if (a < 10)
//         return a;
//     return Summ(a / 10) + a % 10;
// }
// Console.WriteLine("Введите число:");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Summ(numberA));
//-------------------------------------------------------------------------------------------------------------------------------
// **Задача 69:** Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
// int rec(int a, int b)
// {
//     if (b == 1)
//         return a;
//     return rec(a , b - 1) * a;
// }
// Console.WriteLine("Введите первое число:");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int numberB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(numberA, numberB));
