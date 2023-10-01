Console.Clear();

// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
// Вариант 1
// int f(int number)
// {
//     int summa = 0;
//     for (int i = 1; i <= number; i++)
//         summa = summa + i;
//     return summa;
// }
// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(number));
// Вариант 2
// void f(double number)
// {
//     Console.WriteLine((1 + number) / 2 * number);
// }
// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// f(number);


// Задача 26: Напишите программу, которая
// принимает на вход число и выдаёт количество цифр
// в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// void f(int number)
// {
//     int count = 0;
//     while (number > 0)
//     {
//         number = number / 10;
//         count++;
//     }
//     Console.WriteLine(count);
// }
// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// f(number);


// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
// void f(int number, ref int res)
// {
//     for (int i = 1; i <= number;i++)
//         res *= i;
// }
// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// int res = 1;
// f(number, ref res); 
// Console.WriteLine(res); 


// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
void fillArray(int[] array)
{
    for (int i = 0;i < array.Length; i++)
        array[i] = new Random().Next(0, 2);
}
void printArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.WriteLine($"{array[i]} ");
}
int[] array = new int[8];
fillArray(array);
printArray(array);
