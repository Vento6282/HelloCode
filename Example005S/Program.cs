Console.Clear();
//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
// void fillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10);
// }
// void printArray(int[] array)
// {
//     Console.WriteLine($"[{string.Join(", ", array)}]");
// }
// int sumNumbersPositive(int [] array)
// {
//     int result = 0;
//     for (int i = 0;i < array.Length; i++)
//         if(array[i] > 0)
//             result += array[i];
//     return result;
// }
// int sumNumbersNegative(int [] array)
// {
//     int result = 0;
//     for (int i = 0;i < array.Length; i++)
//         if(array[i] < 0)
//             result += array[i];
//     return result;
// }
// int [] array = new int[12];
// fillArray(array);
// printArray(array);
// Console.WriteLine($"Сумна положительных чисел: {sumNumbersPositive(array)}");
// Console.WriteLine($"Сумна отрицательных чисел: {sumNumbersNegative(array)}");


// Задача 32: Напишите программу замена элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.
// void FillArray(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10);
// }
// void PrintArray(int [] array)
// {
//     Console.WriteLine($"[{string.Join(", ", array)}]");
// }
// void RealeseArray(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = array[i] * (-1);
// }
// Console.WriteLine("Введите размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] array = new int[size];
// FillArray(array);
// PrintArray(array);
// RealeseArray(array);
// PrintArray(array);


// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
// void FillArray(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(0, 151);
// }
// int CountNumbers(int [] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] > 9 && array[i] < 100)
//             count += 1;
//     return count;
// }
// int [] array = new int [123];
// FillArray(array);
// Console.WriteLine($"В отрезок [10,99] попадает {CountNumbers(array)} чисел.");


// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний 
// элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
// void FillArray(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(0, 101);
// }
// void PrintArray(int [] array)
// {
//     Console.WriteLine($"[{string.Join(", ", array)}]");
// }
// void Summ(int [] array)
// {
//     for (int i = 0; i <= (array.Length / 2); i++)
//         Console.Write($"{array[i] * array[array.Length - 1 - i]} ");
// }
// Console.WriteLine("Введите размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [size];
// FillArray(array);
// PrintArray(array);
// Summ(array);
