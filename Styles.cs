#nullable disable
using System;

namespace Practice_PROG
{
    public class Styles
    {
        static int? colourIndex;
        public static string name; //Name Set In: Introduction class
        public static void SetTextColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }


        public static void ResetTextStyle()
        {
            Console.ResetColor();
        }

        public static void sectionBreak()
        {
            if (colourIndex == null)
            {
                colourIndex = 0;
            }
            ConsoleColor[] randomColor =
            {
                ConsoleColor.Red,
                ConsoleColor.Green,
                ConsoleColor.Yellow,
                ConsoleColor.Cyan,
                ConsoleColor.Magenta,
                ConsoleColor.White,
                ConsoleColor.Blue
            };
            Console.ForegroundColor = randomColor[colourIndex.Value % randomColor.Length];
            CenterText("==========================SECTION BREAK==========================");
            Console.ResetColor();
            colourIndex++;
        }


        public static void PrintSeparator(ConsoleColor color = ConsoleColor.White)
        {
            SetTextColor(color);
            Console.WriteLine(new string('=', Console.WindowWidth));
            ResetTextStyle();
        }
        public static void CenterText(string text)
        {
            int consoleWidth = Console.WindowWidth;
            int padding = (consoleWidth - text.Length) / 2;

            Console.SetCursorPosition(Math.Max(padding, 0), Console.CursorTop);
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }
            Console.WriteLine();
        }

        public static void CenterArt(string text)
        {
            int consoleWidth = Console.WindowWidth;
            int padding = (consoleWidth - text.Length) / 2;

            Console.SetCursorPosition(Math.Max(padding, 0), Console.CursorTop);
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(8);
            }
            Console.WriteLine();
        }
    }
}//Styles