
Console.WriteLine("enter elmnt_number of your array");
int n = Convert.ToInt32(Console.ReadLine());
double[] ary = new double[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("enter cell for your array");
    ary[i] = Convert.ToInt32(Console.ReadLine());
}


prnt(sort(ary));



static double[] sort(double[] lisst)
{
    int n = lisst.Length;
    int y, t;
    double z;
    for (int i = 0; i < n; i++)
    {
        t = i;
        for (y = i + 1; y < n; y++)
            if (lisst[y] < lisst[t])
                t = y;
        if (t != i)
        {
            z = lisst[i];
            lisst[i] = lisst[t];
            lisst[t] = z;

        }
    }
    return lisst;
}

static void prnt(double[] input)
{
    for (int i = 0; i < input.Length; i++)
    {
        Console.Write(input[i] + " ");
    }
    Console.WriteLine();
}