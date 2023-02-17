
var dictionary = File.ReadAllLines("slowa.txt");

var rnd =new Random();


var invocation = File.ReadAllLines("inwokacja.txt");


foreach(var line in invocation){
    var words = line.Split(" ");

    //var randomWord = words[rnd.Next(words.Length)];

    var randoWordIndex = rnd.Next(words.Length);

    var randomWordInDictionary = dictionary[rnd.Next(dictionary.Length)];

    words[randoWordIndex] = randomWordInDictionary;

    Console.WriteLine(string.Join(" ",words));

    //Console.WriteLine(line.Replace(randomWord, randomWordInDictionary));


}