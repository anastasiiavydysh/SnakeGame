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
        }
    }
}