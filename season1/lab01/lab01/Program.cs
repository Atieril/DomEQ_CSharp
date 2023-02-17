
//Comment 

/*
Multi
line 
comment
*/
 

//Variables
var someNumber = 10;
var someFloatingPointNumber = 10.5;
var someText = "DomEQ";
bool someBoolean = true;


//Printing to Console
Console.WriteLine(someNumber);
Console.WriteLine(someFloatingPointNumber);

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine(someText + " is gay");
Console.ForegroundColor = ConsoleColor.Gray;

//Conditionals
Console.WriteLine("Tell me your name:");
var name = Console.ReadLine();
Console.WriteLine("Are you gay? [y/n]");
var isGayText = Console.ReadLine();

if(isGayText == "y"){
    Console.WriteLine($"{name} is gay AF");
} else {
    Console.WriteLine($"That's a shame :(");
}

//Loops
    //Blue Stripe
for(var i=0;i<10;i++)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("*");
}
Console.WriteLine();

    //Pink Stripe
for(var i=0;i<10;i++)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("*");
}
Console.WriteLine();

    //White Stripe
for(var i=0;i<10;i++)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("*");
}
Console.WriteLine();

//Reset Console colors to default
Console.ResetColor();

