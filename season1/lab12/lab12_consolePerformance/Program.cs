
using Pastel;
using System.Drawing;
using System.Text;


var width = 80;
var height = 40;

var tries = 1000;

Random ra = new Random();

var start = DateTime.Now;
for(var i=0;i<tries;i++){
    //WriteByCharacter();
    WriteAll();
}
var end = DateTime.Now;

Console.WriteLine($"time = {(end-start).TotalMilliseconds/tries}");

 void WriteByCharacter(){
    Console.Clear();
    for(var y=0;y<height;y++){
        for(var x=0;x<width;x++){
            Console.Write("X".Pastel(Color.FromArgb(ra.Next(0,256), ra.Next(0,256), ra.Next(0,256))));
        }
        Console.WriteLine();
    }
}


void WriteAll(){
    Console.Clear();
    var sb=new StringBuilder(width*height*10);
    for(var y=0;y<height;y++){
        for(var x=0;x<width;x++){
            sb.Append("X".Pastel(Color.FromArgb(ra.Next(0,256), ra.Next(0,256), ra.Next(0,256))));
        }
        sb.AppendLine();
    }
    Console.WriteLine(sb.ToString());
}