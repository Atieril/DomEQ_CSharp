
//*******************************************
//Pobieranie pogody dla lokalizacji
//*******************************************
using RestSharp;
using Newtonsoft.Json;

var lat = "50.035897";
var lon = "19.942945";
var apiKey = "<PLACE YOUR TOKEN HERE>";

var url = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={apiKey}&units=metric";

var client = new RestClient();

var request = new RestRequest(url);

var response = client.Execute(request);


var parsed = JsonConvert.DeserializeObject<dynamic>(response.Content);

Console.WriteLine(parsed.main.temp);

//*******************************************
//Jak zwrocici dwie wartosci z jednej funkcji
//*******************************************
//Sposób 1 krotka
(double,double) TestReturn1(){
    return (0,0);
}

var cos1 = TestReturn1();
cos1.Item1.ToString();
cos1.Item2.ToString();

//Sposób 2 własna klasa (patrz Coordinates.cs)
Coordinates TestReturn2(){
    var tmp = new Coordinates();
    tmp.Lat = 0;
    tmp.Lon = 0;
    return tmp;
}

var cos2 = TestReturn2();
cos2.Lat.ToString();
cos2.Lon.ToString();

//Sposób 3 parametry wyjściowe
void TestReturn3(out double lon,out double lat){
    lon = 0;
    lat = 0;
}

double l1;
double l2;
TestReturn3(out l1,out l2);
l1.ToString();
l2.ToString();















