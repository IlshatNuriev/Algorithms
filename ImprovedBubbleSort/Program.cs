// See https://aka.ms/new-console-template for more information


int[] a = new int[] { 5, 1, 4, 2, 8 };

int cmp = 0;
int tr = 0;


for (int k =0; k < a.Length-1; k++)
{
    bool t = false;
    cmp++;
    for (int i = 0; i < a.Length - 1 - k; i++)
    {
        if (a[i] > a[i + 1])
        {
            t = true;
            tr++;
            int tmp = a[i];
            a[i] = a[i + 1];
            a[i + 1] = tmp;
        }
    }
    if (!t)
    {
        break;
    }
}


foreach(int i in a)
{
    Console.WriteLine(i);
}
Console.WriteLine("{0}, {1}", cmp, tr);
Console.ReadLine();