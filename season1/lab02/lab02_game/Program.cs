
var ra = new Random();
var sekret = ra.Next(1,1000000);

var najmniejsza = 1; 
var najwieksza = 1000000;

while(true) // for(;;)
{
    var sugestia = (najwieksza + najmniejsza ) / 2;
    Console.WriteLine("Podaj liczbę "+ najmniejsza +" " + najwieksza + " sugestia: "+ sugestia);
    var tekst = Console.ReadLine();

    var liczba = Convert.ToInt32(tekst);

    if(liczba == sekret){
        Console.WriteLine("Wygrałeś");
        break;
    } else if(liczba < sekret){
        najmniejsza = Math.Max(najmniejsza,liczba);
        
        Console.WriteLine("Za mało");
    } else if(liczba > sekret){
        najwieksza = Math.Min(najwieksza,liczba);
        Console.WriteLine("Za duzo");
    }

}