Console.Clear();

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 11;
int a2 = 12;
int a3 = 39;
int b1 = 21;
int b2 = 22;
int b3 = 23;
int c1 = 314;
int c2 = 32;
int c3 = 33;

Console.WriteLine(Max(Max(a1, a2, a3), Max(b1, b2, b3), Max(c1, c2, c3)));

