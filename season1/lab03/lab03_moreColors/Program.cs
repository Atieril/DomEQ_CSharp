
using System.Drawing;
using Pastel;

Console.WriteLine("Hello".Pastel("#FF0000").PastelBg("#00FF00"));

int r = 225;
int g = 255;
int b = 250;
for (int i = 0; i < 10; i++)
{
    var br = 255-r;
    var bg = 255-g;
    var bb = 255-b;
    
    var text = "Hello";

    //Console.WriteLine($"\u001b[38;2;{r};{g};{b}m\u001b[48;2;{br};{bg};{bb}m{text}\u001b[0m");
    Console.WriteLine(text.Pastel(Color.FromArgb(r, g, b)).PastelBg(Color.FromArgb(br,bg,bb)));

    r -= 18;
    b -= 9;
}

