// See https://aka.ms/new-console-template for more information
Console.WriteLine("Podaj wzrost w cm");
var heightText = Console.ReadLine();
var height = Convert.ToInt32(heightText)/100.0;
Console.WriteLine($"Twój {height:F1} {height} wzrost to {height:F2}");

Console.WriteLine("Podaj wagę w kg");
var weightText = Console.ReadLine();
var weight = Convert.ToInt32(weightText);

var bmi = weight / (height * height);


Console.WriteLine($"Twoje bmi to {bmi:F2}");




