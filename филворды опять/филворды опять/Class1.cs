using System;
using System.Collections.Generic;
using System.Text;
using FillwordsSecTime;

namespace windows
{
    public abstract class DefaultWindow
    {
        public int WindowNumber;
        public int rows;
        public int selectedRow;
        public abstract void Draw();
        public static void SetColor()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public static void SelectedColor()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        public static void WriteRow(string row, bool selected)
        {
            for (int i = 0; i < 36 - (row.Length / 2); i++) Console.Write(" ");
            if (selected) SelectedColor(); else SetColor();
            Console.Write(row);
            Console.ResetColor();
            Console.WriteLine();
        }

    }

    public class MainMenuWindow : DefaultWindow
    {
        public override void Draw()
        {
            Console.CursorVisible = false;
            Console.WriteLine();
            SetColor();
            Console.WriteLine("   ____   ____   __     __     _    _   _____   ____    ____    ___ ");
            Console.WriteLine("  ( ___) (_  _) (  )   (  )   ( |/|/ ) (  _  ) (  _ )  |  _ )  (  __)");
            Console.WriteLine("   )__)   _)(_   )(__   )(__   )    (   )(_)(  | |_| ) | (_) )  ) ___)");
            Console.WriteLine("  (__)   (____) (____) (____) (__/|__) (_____) (_)|_)  |____)  (___)");
            Console.ResetColor();
            Console.WriteLine();
            WriteRow("Новая Игра", selectedRow == 1);
            Console.WriteLine();
            WriteRow("Продолжить", selectedRow == 2);
            Console.WriteLine();
            WriteRow("Рейтинг", selectedRow == 3);
            Console.WriteLine();
            WriteRow("Выход", selectedRow == 4);
        }
    }
}
