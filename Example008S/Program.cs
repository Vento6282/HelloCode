Console.Clear();
// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.
// void FillArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(10, 100);
//         }
//     }
// }
// void PrintArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]}\t"); 
//         }
//         Console.WriteLine();
//     }    
// }
// void HandleArray(int [,] array)
// {
//     int temp = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         temp = array[0,j];
//         array[0,j] = array[array.GetLength(0) - 1, j];
//         array[array.GetLength(0) - 1, j] = temp;
//     }
// }

// int [] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// // Console.ReadLine() -      "1 2 3 4"
// // Split(" ") -              "1","2","3","4"
// // Select(x => int.Parse(x) - 1, 2, 3, 4
// // ToArray() -               [1, 2, 3, 4]
// int [,] matrix = new int [array[0],array[1]];
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// HandleArray(matrix);
// PrintArray(matrix);
//----------------------------------------------------------------------------------------------------------------------------------------------
// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для пользователя.
// void FillArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(10, 100);
//         }
//     }
// }
// void PrintArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]}\t"); 
//         }
//         Console.WriteLine();
//     }    
// }
// void IsPossible(int [,] array)
// {
//     if (array.GetLength(0) == array.GetLength(1)) 
//     {
//         ReverseArray(array);
//         PrintArray(array);
//     }
//     else 
//     {
//         Console.WriteLine("Поменять местами строки и столбцы невозможно!");
//     }
// }
// void ReverseArray(int [,] array)
// {
//     int temp = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = i + 1; j < array.GetLength(1); j++)
//         {
//             temp = array[i,j];
//             array[i,j] = array[j,i];
//             array[j,i] = temp;
//         }
//     }        
// }
// int [] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// // Console.ReadLine() -      "1 2 3 4"
// // Split(" ") -              "1","2","3","4"
// // Select(x => int.Parse(x) - 1, 2, 3, 4
// // ToArray() -               [1, 2, 3, 4]
// int [,] matrix = new int [array[0],array[1]];
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// IsPossible(matrix);
//----------------------------------------------------------------------------------------------------------------------------------------------
// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
// void FillArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0, 10);
//         }
//     }
// }
// void PrintArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]}\t"); 
//         }
//         Console.WriteLine();
//     }    
// }
// void StatShow(int [,] array)
// {
//     int max = array[0,0];
//     int min = array[0,0];
//     int count;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i,j] > max) max = array[i,j];
//             if (array[i,j] < min) min = array[i,j];
//         }
//     }
//     for (int k = min; k <=max; k++)
//     {
//         count = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (array[i,j] == k) count++;
//             }
//         }   
//         if (count > 0) Console.WriteLine($"{k} встречается {count} {Raz(count)}.");
//     }
// }
// string Raz(int count)
// {
//     if (count % 10 == 0 || count % 10 == 1 || count % 10 == 5 || count % 10 == 6 || count % 10 == 7 || count % 10 == 8 || count % 10 == 9) return "раз";
//     else return "раза";
// }
// int [] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// // Console.ReadLine() -      "1 2 3 4"
// // Split(" ") -              "1","2","3","4"
// // Select(x => int.Parse(x) - 1, 2, 3, 4
// // ToArray() -               [1, 2, 3, 4]
// int [,] matrix = new int [array[0],array[1]];
// FillArray(matrix);
// PrintArray(matrix);
// StatShow(matrix);
//----------------------------------------------------------------------------------------------------------------------------------------------
// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// void FillArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0, 10);
//         }
//     }
// }
// void PrintArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]}\t"); 
//         }
//         Console.WriteLine();
//     }    
// }
// int [,] DeleteRowAndColumn(int [,] array)
// {
//     int min_i= 0;
//     int min_j= 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[min_i,min_j] < array[i,j])
//             {
//                 min_i = i;
//                 min_j = j;
//             }
//         }
//     }
//     int [,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
//     for (int i = 0; i < array.GetLength(0)-1; i++)
//     {
//         for (int j = 0; j < array.GetLength(1)-1; j++)
//         {
//             if(i < min_i && j < min_j) newArray[i,j] = array[i,j];
//             if(i < min_i && j >= min_j) newArray[i,j] = array[i,j+1];            
//             if(i >= min_i && j < min_j) newArray[i,j] = array[i+1,j];  
//             if(i >= min_i && j >= min_j) newArray[i,j] = array[i+1,j+1];  
//         }
//     }   
//     return newArray;
// }
// int [] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// // Console.ReadLine() -      "1 2 3 4"
// // Split(" ") -              "1","2","3","4"
// // Select(x => int.Parse(x) - 1, 2, 3, 4
// // ToArray() -               [1, 2, 3, 4]
// int [,] matrix = new int [array[0],array[1]];
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// int [,] newMatrix = DeleteRowAndColumn(matrix);
// PrintArray(newMatrix);
//----------------------------------------------------------------------------------------------------------------------------------------------