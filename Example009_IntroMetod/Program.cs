int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > arg1) result = arg2;
    if (arg3 > arg2) result = arg3;
    return result;     
}

int a = 3, b = 160, c = 8,
    a2 = 6, b2 = 59, c2 = 5,
    a3 = 16, b3 = 31, c3 = 25;

int max1 = Max(a, b, c);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);


Console.Write("MAX = ");
Console.WriteLine(max);
