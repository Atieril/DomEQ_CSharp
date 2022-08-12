

// var i = 10;
// var whatever = 4+3*5;
// Console.WriteLine("Ile to jest: " + whatever);

Console.WriteLine("Podaj imię:");
var imie = Console.ReadLine();



if(imie == "Sara")
{
    Console.WriteLine("Witaj "+imie);   
} 
else if(imie == "Władek")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("O nie to ja nie pracuję"); 
    Console.ResetColor();
}
else
{
    Console.WriteLine("Spadaj "+imie);   
}


var ra =new Random();
ra.Next(1,100);

