
if(File.Exists("plik.txt")){
    var oldText = File.ReadAllText("plik.txt");

    Console.WriteLine("Stary tekst:");
    Console.WriteLine(oldText);
}

Console.WriteLine("Podaj tekst:");
var text = Console.ReadLine();

//File.WriteAllText("plik.txt",text);
File.AppendAllText("plik.txt",text + Environment.NewLine);


