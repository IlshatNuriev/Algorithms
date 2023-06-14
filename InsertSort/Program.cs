// See https://aka.ms/new-console-template for more information

int[] a = new int[] { 4, 2, 7, 9, 6, 1 };

for(int i = 0; i < a.Length; i++)
{
    int x = a[i];
    
    for(int j  = i - 1; j >= 0 && a[j] > x; j--)
    {
        a[j + 1] = a[j];
        a[j] = x;
    }
}


foreach (int i in a)
{
    Console.WriteLine(i);
}
//Console.WriteLine("{0}, {1}", cmp, tr);
Console.ReadLine();
