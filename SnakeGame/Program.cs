using SnakeGame.UI;

namespace SnakeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UIService uIService = new UIService();
            Menu menu = uIService.GetMenu();
            while (true)
            {
                uIService.GetCommand(menu, Console.ReadKey().Key);
            }
                // Console.SetWindowSize(120, 30);
            // Console.SetBufferSize(120, 30);
            //Menu menu = new Menu( new Dictionary<int, string> {
            //    { 0,"Start" },
            //    { 1,"Exit"}
            //});
            //while (true)
            //{
            //    menu.DisplayMenu();
            //    ConsoleKeyInfo key = Console.ReadKey();
            //    menu.PressKey(key.Key);
            //}

        }
    }
}