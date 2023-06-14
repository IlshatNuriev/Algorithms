// See https://aka.ms/new-console-template for more information
int Factorial(int n)
{
    if (n == 1)
        return 1;

    return n * Factorial(n - 1);
}



Console.WriteLine(Factorial(5));

Console.ReadKey();
