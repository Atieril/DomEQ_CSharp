// See https://aka.ms/new-console-template for more information


// Console.WriteLine("Jak masz na imię?");
// var imie = Console.ReadLine();
// Console.WriteLine("Witaj " + imie);


Console.ForegroundColor =ConsoleColor.Red;
Console.WriteLine(7.0/2.0);
Console.ResetColor();



var pieniadze = 1000;

var rand = new Random();


//while(pieniadze>0){
for(var i=0;i<3;i++){
    var los = rand.NextSingle();

    Console.WriteLine($"[{i}] Masz {pieniadze} eurogąbek");
    Console.WriteLine("Obstawiać!!!!! [o/j]");

    var obstawienie = Console.ReadLine();

    Console.WriteLine("Kwota?");
    var kwota = Console.ReadLine();

    var kwotaLiczbowo = Convert.ToInt32(kwota);

    if(kwotaLiczbowo < 0 || kwotaLiczbowo > pieniadze ){
        kwotaLiczbowo = 0;
    }

    var literka = obstawienie[0];


    if(los < 0.7){
        Console.WriteLine("Orzeł");
        if(literka == 'o'){
            Console.WriteLine("YAY");
            pieniadze = (int)(pieniadze + kwotaLiczbowo * 1.2);
        } else {
            Console.WriteLine("NAY");
            pieniadze = pieniadze - kwotaLiczbowo;
        }
    } else {
        Console.WriteLine("Jaszczomp");
        if(literka == 'j'){
            Console.WriteLine("YAY");
            pieniadze = (int)(pieniadze + kwotaLiczbowo * 2);
        } else {
            Console.WriteLine("NAY");
            pieniadze = pieniadze - kwotaLiczbowo;
        }
    }


    Console.WriteLine($"Masz {pieniadze} eurogąbek");

}

Console.WriteLine($"Koniec gry Twój wynik [{pieniadze}] :(");