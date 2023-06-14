// See https://aka.ms/new-console-template for more information

int[] a = new int[] { 100, 26, 5, 12, 8, 10, 1 };

int b = 0;
int c = 0;

for (int k = 0; k < a.Length-1; k++)
{
    for (int i = 0; i < a.Length - 1 - k; i++)
    {
        if (a[i] > a[i + 1])
        {
            int tmp = a[i];
            a[i] = a[i + 1];
            a[i + 1] = tmp;
        }

        c++;
    }
    b++;
}

foreach(int i in a)
{
    Console.WriteLine(i);
}

Console.WriteLine("{0}, {1}", b, c);

Console.ReadKey();
