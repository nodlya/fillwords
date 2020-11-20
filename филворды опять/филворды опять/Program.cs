using System;
using windows;

namespace FillwordsSecTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentWindow = 1;
            Console.Title = "fillwords";
            Console.SetWindowSize(72, 20);
            MainMenuWindow MainMenu = new MainMenuWindow();
            SetWindow(MainMenu, 4, 1);
            if (currentWindow == 1) MainMenu.Draw();
        }

        static void SetWindow(MainMenuWindow Window, int rows, int WindowNumber)
        {
            Window.rows = rows;
            Window.selectedRow = 1;
            Window.WindowNumber = WindowNumber;
        }
    }
}
