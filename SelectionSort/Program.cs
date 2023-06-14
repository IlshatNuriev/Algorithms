// See https://aka.ms/new-console-template for more information


int[] a = new int[] { 4, 2, 7, 9, 6, 1 };

for(int i = 0; i < a.Length; i++)
{
    int min = i;
    for(int j = i + 1; j < a.Length; j++)
    {
        if (a[j] < a[min])
        {
            min = j;
        }
    }

    int tmp = a[min];
    a[min] = a[i];
    a[i] = tmp;
}

foreach (int i in a)
{
    Console.Write(i + ", ");
}
//Console.WriteLine("{0}, {1}", cmp, tr);
Console.ReadLine();
