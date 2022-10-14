

Console.WriteLine("Podaj rozmiar tabliczki:");
var text = Console.ReadLine();
var max = Convert.ToInt32(text);

var biggestNumber = max*max;

var padding = biggestNumber.ToString().Length + 1;

for(int i=1 ;i<=max ; i++)
{
    for (int j=1;j<=max;j++)
    {
        Console.Write((i*j).ToString().PadLeft(padding));
    }
    Console.WriteLine();
}