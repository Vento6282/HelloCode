Console.Clear();

// **Задача 39:** Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
// void FillArray(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(0, 11);
// }
// void PrintArray(int [] array)
// {
//     Console.WriteLine($"[{string.Join(",", array)}]");
// }
// void ReverseArray(int [] array)
// {
//     int temp = 0;
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         temp = array[i];
//         array[i] = array[array.Length - i -1];
//         array[array.Length -i - 1] = temp;
//     }    
// }
// int [] array = new int [9];
// FillArray(array);
// PrintArray(array);
// ReverseArray(array);
// PrintArray(array);


// **Задача 40:** Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// **Теорема о неравенстве треугольника:** каждая сторона треугольника меньше суммы двух других сторон.

// string ExistTriangle(int [] array)
// {
//     if (array[0] < array[1] + array[2] && array[1] < array[0] + array[2] && array[2] < array[1] + array[0])
//         return "Треугольник с введёнными сторонами существует!";
//     else return "Треугольник не существует!";
// }
// int [] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// // Console.ReadLine() -      "1 2 3 4"
// // Split(" ") -              "1","2","3","4"
// // Select(x => int.Parse(x) - 1, 2, 3, 4
// // ToArray() -               [1, 2, 3, 4]
// Console.WriteLine($"[{string.Join(",", array)}]");
// Console.WriteLine(ExistTriangle(array));


// **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.Write("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// string res = string.Empty;
// while (number > 0)
// {
//     res = Convert.ToString(number % 2) + res;
//     number /= 2;
// }
// Console.WriteLine(res);


// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// **Числа Фибоначчи** — числовая ****последовательность, каждый элемент которой равен сумме двух предыдущих.

// void Fibonacci(int [] array)
// {
//     if (array.Length >= 1) array[0] = 0;
//     if (array.Length >= 2) array[1] = 1;
//     for (int i = 2; i < array.Length; i++)
//         array[i] = array[i - 1] + array [i - 2];
// }
// void PrintArray(int [] array)
// {
//     Console.WriteLine($"{string.Join(" ", array)}");
// }
// Console.Write("Введите количество чисел последовательности Фибоначчи:");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [size];
// Fibonacci(array);
// PrintArray(array);