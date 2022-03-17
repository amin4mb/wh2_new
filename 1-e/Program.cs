Console.WriteLine("enter elmnt_number of **first** your array");
int n = Convert.ToInt32(Console.ReadLine());
int[] ary = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"enter number ({i + 1})");
    ary[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("enter elmnt_number of **second** your array");
int m = Convert.ToInt32(Console.ReadLine());
int[] aryy = new int[m];
for (int i = 0; i < m; i++)
{
    Console.WriteLine($"enter number ({i + 1})");
    aryy[i] = Convert.ToInt32(Console.ReadLine());
}
List<int> listrepetition = new List<int>();

for (int i = 0; i < ary.Length; i++)
{
    for(int j=0; j < aryy.Length; j++){
        if (ary[i] == aryy[j] && listrepetition.Contains(ary[i]) ==false )
        { 
        listrepetition.Add(ary[i]); 
        }
    }
}
Console.Clear();

foreach (var item in listrepetition)
{
    Console.WriteLine(item);
}