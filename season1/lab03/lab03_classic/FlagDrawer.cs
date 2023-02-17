using System;

namespace lab03_classic
{
    static class FlagDrawer
    {
        public static void DrawTransFlag()
        {

            var flag = new [] {ConsoleColor.Cyan,ConsoleColor.Magenta,ConsoleColor.White,ConsoleColor.Magenta,ConsoleColor.Cyan};
            DrawFlag(10,flag);
            
        }

        private static void DrawLine(int length, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            for(var i=0;i<length;i++)
            {
                Console.Write("*");
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        private static void DrawFlag(int length, ConsoleColor[] flag)
        {
            for(var i=0;i<flag.Length;i++)
            {
                DrawLine(length,flag[i]);
            }
            Console.WriteLine();
        }
    }
}
