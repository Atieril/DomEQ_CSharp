//All console colors
Console.WriteLine("========COLORS========");  
foreach(ConsoleColor color in Enum.GetValues(typeof(ConsoleColor))) {  
    Console.ForegroundColor = color;
    Console.Write($"Color is set to {color}");  
    Console.ResetColor();
    Console.WriteLine();
}

