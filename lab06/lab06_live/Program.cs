

//*******************************************
//Zamien pierwsza i ostatnia czesc imienia
//*******************************************
string RotateName(string name)
{
    var splitted = name.Split(" ");

    var tmp = splitted[0];
    splitted[0] = splitted[splitted.Length-1];
    splitted[splitted.Length-1] = tmp;

    var reversed = string.Join(" ",splitted);
    return reversed;
}

var oldName = "John George Smith";
var newName = RotateName(oldName);

Console.WriteLine(newName);