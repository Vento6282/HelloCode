// Console.Clear();

// int [] array = {11, 21, 31, 41, 14, 17, 86, 164, 234, 32, 13};
// int max = array[0];
// for(int i = 1;i < array.Length; i++)
//     if (array[i] > max) max = array[i];
// Console.WriteLine(max);

Console.Clear();

void FillArray (int[] collecction)
{
    int length = collecction.Length;
    for(int i = 0; i < length; i++)
        collecction[i] = new Random().Next(1,100);
}

void PrintArray(int[] collecction)
{
    int length = collecction.Length;
    for(int i = 0; i < length; i++)
        Console.Write(collecction[i] + " ");
    Console.WriteLine();
}

int [] array = new int[10];

FillArray(array);
PrintArray(array);

