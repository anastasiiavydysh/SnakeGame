using SnakeGame.UserServices;

namespace SnakeGame.UI
{
    public class Menu
    {
        Dictionary<int, string> _menus = new Dictionary<int, string>();
        int _selectedItem = 0;
        private GamePlay _gamePlay = new GamePlay();
        private UserService _userServices = new UserService();
        private User _user = new User();

        public Menu(Dictionary<int, string> menus)
        {
            _menus = menus;
        }

        public void DisplayMenu()
        {
            Console.Clear();
            foreach (var item in _menus)
            {
                Console.ResetColor();
                if (_selectedItem >= _menus.Count || _selectedItem < 0)
                    _selectedItem = 0;
                if (item.Key == _selectedItem)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(item.Value);
                }
                else
                    Console.WriteLine(item.Value);
            }
        }

        public void HideMenu()
        {
            Console.Clear();
        }

        public void PressKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    _selectedItem--;
                    DisplayMenu();
                    break;
                case ConsoleKey.DownArrow:
                    _selectedItem++;
                    DisplayMenu();
                    break;
                case ConsoleKey.Enter:
                    SelectItem();
                    break;
                default:
                    _selectedItem = 0;
                    DisplayMenu();
                    break;
            }
        }

        private void SelectItem()
        {
            switch (_selectedItem)
            {
                case 0:
                    Console.Clear();
                    _gamePlay.StartGame(_user);
                    break;
                case 1:
                    Console.Clear();
                    _userServices.DisplayAllUsers();
                    break;
                case 2:
                    Console.Clear();                    
                    _user = _userServices.EnterNewUser();                    
                    break;
                case 3:
                    Environment.Exit(0);
                    return;
            }
        }
    }
}
