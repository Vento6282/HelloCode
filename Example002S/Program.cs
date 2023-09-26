Console.Clear();
// Функция
// void f(ref int x)
// {
//     x += 5;
//     Console.WriteLine(x);
// }
// int x = 10;
// Console.WriteLine(x);  
// f(ref x);
// Console.WriteLine(x);  


// Процедура
// int f(int a, int b)
// {
//     if (a > b) return a;
//     return b;
// }
// Console.WriteLine(f(10,5));


// Первый способ
// Console.WriteLine("Введите первое число:");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x>0 && y>0) Console.WriteLine(1);
// else if (x<0 && y<0) Console.WriteLine(3);
// else if (x<0 && y>0) Console.WriteLine(2);
// else if (x>0 && y<0) Console.WriteLine(4);
// else Console.WriteLine("В введённых координатах есть 0!");

// Второй способ
// string f(int x, int y)
// {
//     if (x>0 && y>0) return "1";
//     else if (x<0 && y<0) return "3";
//     else if (x<0 && y>0) return "2";
//     else if (x>0 && y<0) return "4";
//     else return "В введённых координатах есть 0!";
// }
// Console.WriteLine("Введите первое число:");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(x, y));


// string f(int x)
// {
//     if (x ==1) return "x>0 и y>0";
//     else if (x == 3) return "x<0 и y<0";
//     else if (x == 2) return "x<0 и y>0";
//     else if (x == 4) return "x>0 и y<0";
//     else return "Такой четверти нет!";
// }
// Console.WriteLine("Введите четверть:");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(x));


// Console.WriteLine("Введите x1:");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y1:");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите x2:");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y2:");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2)), 2));


int f(int i)
{
    return i * i;
}
Console.WriteLine("Введите число:");
int x = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < x; i++)
    Console.Write(f(i) + " ");