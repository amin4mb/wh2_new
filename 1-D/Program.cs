
string[] array = { "rasol", "amin", "ali", "amin", "ali", "bashir", "nashir", "amin", "nashir", "ali" };
string[,] ar = new string[array.Length, 2];
for (int i = 0; i < array.Length; i++)
{
    int k = 1;
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] == array[i] && array[i] != "*")
        {
            k = k + 1;
            array[j] = "*";
        }
    }
    ar[i, 0] = array[i];

    ar[i, 1] = Convert.ToString(k);
}

//int n = 4;
//Console.WriteLine($"index:{n}  element:{ar[n, 0]}  valeu:{ar[n, 1]}");

for (int n = 0; n < array.Length; n++)
{
    if (ar[n, 0] != "*" && ar[n, 1] != "1")
    {
        Console.WriteLine($"index:{n}  element:{ar[n, 0]}  valeu:{ar[n, 1]}");
    }
}

