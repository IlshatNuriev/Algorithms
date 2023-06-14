// See https://aka.ms/new-console-template for more information


int[] nums = new int[] { 1, 3, 5, 6, 8, 10, 11, 14, 16, 19, 20, 22 };

bool IsFound = false;

foreach (var i in nums)
{
    Console.Write(i + ", ");
}

Console.WriteLine();

Console.WriteLine("Введите искомый элемент");

int x = int.Parse(Console.ReadLine());

Console.WriteLine(x);

int a = 0;
int b = nums.Length-1;

while (a <= b)
{
    int k = (a + b) / 2;
    if (nums[k] == x)
    {
        IsFound = true;
        Console.WriteLine(k);
        
        break;
        Console.ReadKey();
    }
    else if(nums[k] > x)
    {
        b = k-1;
    }
    else if (nums[k] < x)
    { 
        a = k+1; 
    }
}

if (!IsFound)
{
    Console.WriteLine("Искомый элемент не найден");
    Console.ReadKey();
}


