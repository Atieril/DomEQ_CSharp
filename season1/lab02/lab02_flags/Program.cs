void DrawLine(int length, ConsoleColor color)
{
    Console.ForegroundColor = color;
    for(var i=0;i<length;i++)
    {
        Console.Write("*");
    }
    Console.ResetColor();
    Console.WriteLine();
}

void DrawFlag(int length, ConsoleColor[] flag)
{
    for(var i=0;i<flag.Length;i++)
    {
        DrawLine(length,flag[i]);
    }
    Console.WriteLine();
}

Console.WriteLine("🏳️‍⚧️");
var hkjhsgdkj = new [] {ConsoleColor.Cyan,ConsoleColor.Magenta,ConsoleColor.White,ConsoleColor.Magenta,ConsoleColor.Cyan};

DrawFlag(20,hkjhsgdkj);
DrawFlag(20,new [] {ConsoleColor.White,ConsoleColor.Red});
