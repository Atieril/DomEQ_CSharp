using Pastel;
using System.Drawing;

Console.WriteLine("Hello, World!".Pastel(Color.FromArgb(255, 0, 0)));




// var cnt =0;
// for(;;){
//     Console.Clear();
//     for (var i=0;i<cnt%10;i++){
//             Console.Write("*");
//     }
//     Console.Write("*");
//     Thread.Sleep(1000);
//     cnt++;
// }

void AnimationForwards()
{
    for(var cnt =0;cnt<10;cnt++)
    {
        DrawStar(cnt);
    }
}

void AnimationBackwards()
{
    for(var cnt =10;cnt>0;cnt--)
    {
       DrawStar(cnt);
    }
}

void DrawStar(int cnt){
     Console.Clear();
        for (var i=0;i<cnt;i++){
            Console.Write(" ");
    }
    Console.Write("*");
    Thread.Sleep(100);
}

while(true)
{
    AnimationForwards();
    AnimationBackwards();
}