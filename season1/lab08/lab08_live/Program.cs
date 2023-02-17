
string Encrypt(string str,string alphabet,int[] key){
    var result = new List<char>();
    for(var i=0;i<str.Length;i++)
    {
        var c = str[i];
        var idx = alphabet.IndexOf(c);
        var newIdx = (idx + key[i%key.Length]) % alphabet.Length;
        result.Add(alphabet[newIdx]);
    }
    return new string(result.ToArray());
}

string Decrypt(string str,string alphabet,int[] key){
    var result = new List<char>();
    for(var i=0;i<str.Length;i++)
    {
        var c = str[i];
        var idx = alphabet.IndexOf(c);
        var newIdx = (idx -  key[i%key.Length] + alphabet.Length) % alphabet.Length;
        result.Add(alphabet[newIdx]);
    }
    return new string(result.ToArray());
}

int[] GetKey(string password, string alphabet){
    var key =new int[password.Length];
    for(var i=0;i<password.Length;i++){
        key[i] = alphabet.IndexOf(password[i]);
    }
    return key;
}

int[] BetterGetKey(string password, string alphabet) => password
        .Select(c=> alphabet.IndexOf(c))
        .ToArray();





var alphabet = "abcdefghijklmnopqrstuvwxyz ";

Console.WriteLine("Podaj tekst:");

var text = Console.ReadLine();

var key = GetKey("haselko",alphabet);

var encryptedText = Encrypt(text,alphabet,key);

Console.WriteLine($"Zaszyfrowane: {encryptedText}");

var decpryptedText = Decrypt(encryptedText,alphabet,key);

Console.WriteLine($"Odszyfrowane: {decpryptedText}");