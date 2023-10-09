Console.Clear();
//-----------------------------------------------------------------------------------------------------------------------
// Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// void FillArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j =0; j < array.GetLength(1); j++)
//             array[i,j] = new Random().Next(10, 100);
//     }
// }
// void PrintArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j =0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j]+"\t");
//         Console.WriteLine();
//     }
// }
// Console.WriteLine("Введите количество строк массива:");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива:");
// int column = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int[row, column];
// FillArray(array);
// PrintArray(array);
//-----------------------------------------------------------------------------------------------------------------------
// Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
// void FillArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j =0; j < array.GetLength(1); j++)
//             array[i,j] = i + j;
//     }
// }
// void PrintArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j =0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j]+"\t");
//         Console.WriteLine();
//     }
// }
// Console.WriteLine("Введите количество строк массива:");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива:");
// int column = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int[row, column];
// FillArray(array);
// PrintArray(array);
//-----------------------------------------------------------------------------------------------------------------------
// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// void FillArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i,j] = new Random().Next(2, 10);
//     }
// }
// void PrintArray(int [,] array)
// {
//     for (int i =0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i,j]}\t");
//         Console.WriteLine();
//     }
// }
// void HandleArray(int [,] array)
// {
//     for (int i = 1; i < array.GetLength(0); i += 2)
//     {
//         for (int j = 1; j < array.GetLength(1); j += 2)
//             array[i,j] *= array[i,j];
//     }    
// }
// Console.WriteLine("Введите количество строк массива:");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива:");
// int column = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int[row, column];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// HandleArray(array);
// PrintArray(array);
//-----------------------------------------------------------------------------------------------------------------------
// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// void FillArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i,j] = new Random().Next(2, 10);
//     }
// }
// void PrintArray(int [,] array)
// {
//     for (int i =0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i,j]}\t");
//         Console.WriteLine();
//     }
// }
// int HandleArray(int [,] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             if (i == j) result += array[i,j];
//     }    
//     return result;
// }
// Console.WriteLine("Введите количество строк массива:");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива:");
// int column = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int[row, column];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine($"Сумма главной диагонали = {HandleArray(array)}");