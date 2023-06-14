// See https://aka.ms/new-console-template for more information

int[] a = new int[10] { 5, 2, 4, 1, 3, 8, 6, 7, 9, 10 };

int min = a[0];
int max = a[0];

for(int i = 1; i < a.Length; i++)
{
    if(a[i] < min)
    {
        min = a[i];
    }
    if (a[i] > max) {  max = a[i]; }
}

Console.WriteLine("{0}, {1}", min, max);
Console.ReadKey();
