Console.WriteLine("enter elmnt_number of your array");
int n = Convert.ToInt32(Console.ReadLine());
int[] ary = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"enter number ({i + 1})");
    ary[i] = Convert.ToInt32(Console.ReadLine());
}

int min = ary[0];
for (int i = 1; i < ary.Length; i++)
{

    if (ary[i] < min)
        min = ary[i];
}
Console.WriteLine($"min = {min}");


