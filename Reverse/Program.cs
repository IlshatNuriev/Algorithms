// See https://aka.ms/new-console-template for more information

int[] nums = new int[] { 1, 3, 5, 6, 8, 10, 11, 14, 16, 19, 20, 22, 25 };

int n = nums.Length;

int k = n / 2;

int tmp = 0;


for (int i = 0; i < k; i++)
{
    tmp = nums[i];
    nums[i] = nums[n-i-1];
    nums[n-i-1] = tmp;
}

foreach(var el in nums)
{
    Console.Write($"{el} \t");
}


Console.ReadKey();
