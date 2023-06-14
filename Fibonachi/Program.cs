// See https://aka.ms/new-console-template for more information

int Fibonachi(int n)
{
    if (n == 0 || n == 1) return n;

    return Fibonachi(n - 1) + Fibonachi(n - 2);
}

Console.WriteLine(Fibonachi(10));



static int Fibonachi2(int n)
{
    int result = 0;
    int b = 1;
    int tmp;

    for (int i = 0; i < n; i++)
    {
        tmp = result;
        result = b;
        b += tmp;
    }

    return result;
}

Console.WriteLine(Fibonachi2(10));

Console.ReadKey();
