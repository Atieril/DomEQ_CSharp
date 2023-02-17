using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab08_cryptosite.Pages;

public class IndexModel : PageModel
{

    public string EncryptedText {get;set;}
    public string DecryptedText {get;set;}


    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }


    public void OnGet(string? toEncrypt)
    {
        if (toEncrypt== null){
            return;
        }

        var alphabet = "abcdefghijklmnopqrstuvwxyz ";
        var key = GetKey("haselko",alphabet);

        EncryptedText = Encrypt(toEncrypt,alphabet,key);
        DecryptedText = Decrypt(toEncrypt,alphabet,key);
    }


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

}
