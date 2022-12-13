using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.UI
{
    public class UIService
    {
        public Menu GetMenu()
        {
            //menu
            Menu menu = new Menu(new Dictionary<int, string>() 
            { 
                { 0, "Start"},
                { 1, "Results"},
                { 2, "Add user"},
                { 3, "Exit" }
            });
            menu.DisplayMenu();
            return menu;
        }

        public void GetCommand(Menu menu, ConsoleKey key)
        {
            menu.PressKey(key);
        }
    }
}
