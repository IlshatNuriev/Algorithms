// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите массив через пробел: ");

int[] nums = Console.ReadLine().Trim().Split().Select(w => int.Parse(w)).ToArray();

foreach (var i in nums)
{
    Console.Write(i + ", ");
}

Console.WriteLine();

Console.WriteLine("Введите искомое число: ");

int x = int.Parse(Console.ReadLine());

Console.WriteLine(x);

bool found = false;
int k = 0;

for(int i = 0; i < nums.Length; i++)
{
    if (nums[i] == x)
    {
        found = true;
        k = i;
        break;
    }
}

if (found)
{
    Console.WriteLine("Индекс искомого элемента: {0}", k);
}
else
{
    Console.WriteLine("Искомый элемент не найден");
}