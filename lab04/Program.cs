
void ObrocZdanie()
{
    Console.WriteLine("Podaj zdanie:");
    var zdanie = Console.ReadLine();
    var slowa = zdanie.Split(" ");

    for (var i = slowa.Length - 1; i >= 0; i--)
    {
        Console.Write(slowa[i] + " ");
    }
    Console.WriteLine();
}

bool IsPalindrom(string slowo)
{
    var palindromCheck = true;
    for (var i = 0; i < slowo.Length / 2; i++)
    {
        var j = slowo.Length - i - 1;
        if (slowo[i] != slowo[j])
        {
            palindromCheck = false;
            break;
        }
    }
    return palindromCheck;
}

void CzyJestPalindromem()
{
    // Drugi program
    // i = 0 1 2 3 4 
    // j = 5-0-1 5-1-1 5-2-1 5-3-1 5-4-1
    // j = 4 3 2 1 0

    Console.WriteLine("Podaj słowo:");
    var slowo = Console.ReadLine();

    var isPalindrom = IsPalindrom(slowo);

    if (isPalindrom)
    {
        Console.WriteLine("Jest palindromem");
    }
    else
    {
        Console.WriteLine("Nie jest palindromem");
    }
}


void LiczbyParzysteBedacePalindromami()
{
    Console.WriteLine("Podaj liczbę:");
    var nText = Console.ReadLine();

    var n = Convert.ToInt32(nText);

    var iloscLiczbParzystych = 0;

    for (var i = 1; i < n; i++)
    {
        if (i % 2 == 0 && IsPalindrom(i.ToString()))
        {
            iloscLiczbParzystych++;
        }
    }

    Console.WriteLine($"Liczb parzystych mniejszych niz {n} które są palindromem jest {iloscLiczbParzystych}");
}


//Zadanie 1
ObrocZdanie();

//Zadanie 2
CzyJestPalindromem();

//Zadanie 3
LiczbyParzysteBedacePalindromami();


