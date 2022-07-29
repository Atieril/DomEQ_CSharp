// See https://aka.ms/new-console-template for more information
// ghhkjsdhgkjshdgjkhsd
/*
koentarz 
na wlebnjsxfskhgk
*/

//var name = "Adaś";

Console.WriteLine("Jak masz na imię?");
var name = Console.ReadLine();


if(name == "Sara")
{
    Console.WriteLine("A to ty, "+ name);
} 
else if (name == "Adam")
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.BackgroundColor = ConsoleColor.Red;
    for(var i=0;i<10;i++){
        Console.Write("AAAA ");
        Console.WriteLine(name + " ma sami wiecie co");
    }
    Console.ResetColor();
}
else 
{
    Console.WriteLine("Witaj " + name);
}

