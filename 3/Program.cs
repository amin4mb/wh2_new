Console.WriteLine("enter your character");
var input = Console.ReadLine();

List<string> inputlist = new List<string>();



for (int i = 0; i < input.Length;)
{
    
    string x = "";
    int j = i;
    for (j =i ; j < input.Length; j++)
    {   if ( input[j]==' ' )
        {
            break;
        }
        x = x + input[j];
    }
    inputlist.Add(x);
    i = j+1;

}

foreach (var item in inputlist)
{
    Console.WriteLine(item);
}
