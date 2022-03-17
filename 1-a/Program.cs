
Console.WriteLine("****** Reverse ******");
Console.WriteLine("enter elmnt_number of your array");
int n = Convert.ToInt32(Console.ReadLine());
int[] ary = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"enter number ({i + 1})");
    ary[i] = Convert.ToInt32(Console.ReadLine());
}


int[] ReversMetode(int[] ary)
{
    int[] aryReverse = new int[ary.Length];
    int j = 0;
    for (int i = ary.Length - 1; i >= 0; i--)
    {
        aryReverse[j] = ary[i];
        j = j + 1;
    }
    return aryReverse;
}

var aryReverse = ReversMetode(ary);

foreach (var item in aryReverse)
{
    Console.Write(item  + ", ");

}