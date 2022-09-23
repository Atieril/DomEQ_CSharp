using RestSharp;
using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        var apiKey = "<PLACE YOUR TOKEN HERE>";
        var lat = "50.035879";
        var lon = "19.942980";

        RestClient client = new RestClient();
        var request = new RestRequest($"https://api.openweathermap.org/data/2.5/weather?appid={apiKey}&lat={lat}&lon={lon}");

        var response = client.ExecuteGet(request);
        var weather = JsonConvert.DeserializeObject<dynamic>(response.Content);
        Console.WriteLine(weather);
    }
}