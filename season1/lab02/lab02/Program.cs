

void DrawLine(int length,ConsoleColor color)
{
    Console.ForegroundColor = color;
    for(var i=0; i<length;i++)
    {
        Console.Write("*");
    }
    Console.ResetColor();
    Console.WriteLine();
}

void DrawFlag(int size, ConsoleColor[] colors)
{
    for(var i = 0;i<colors.Length;i++){
        DrawLine(size,colors[i]);
    }
}

var array = new[] {ConsoleColor.Cyan, ConsoleColor.Magenta, ConsoleColor.White, ConsoleColor.Magenta, ConsoleColor.Cyan };

var ra = new Random();
var size = ra.Next(10,20);

DrawFlag(size, array);

