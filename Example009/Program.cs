Console.Clear();

// string [,] table = new string[2, 5];
// table[1, 2] = "слово";
// for (int i = 0; i < 2; i++)
// {
//     for (int j = 0;j < 5; j++)
//     {
//         Console.Write($"-{table[i, j]}-\t");
//     }
//     Console.WriteLine();
// }


// int [,] numbers = new int[3,5];
// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 5; j++)
//     {
//         numbers[i,j] = new Random().Next(10, 100);
//     }
// }
// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     for (int j = 0;j < numbers.GetLength(1); j++)
//     {
//         Console.Write($"{numbers[i, j]}\t");
//     }
//     Console.WriteLine();
// }


// void FillMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(10, 100);
//         }
//     }
// }
// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0;j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }
// int [,] numbers = new int[3,5];
// FillMatrix(numbers);
// PrintMatrix(numbers);


// int Factorial(int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// System.Console.WriteLine(Factorial(8));


// int Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
// for (int i = 1; i < 10; i++)
// {
//     Console.WriteLine(Fibonacci(i));
// }