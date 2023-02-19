using SnakeGame.Factory;
using SnakeGame.Helpers;
using SnakeGame.Installers;
using SnakeGame.UserServices;
using static System.Formats.Asn1.AsnWriter;

namespace SnakeGame
{
    public class GamePlay
    {
        public GamePlay(){}

        public void StartGame(User user)
        {
            if(user == null)
                user = new User();

            int score = 0;

            LineInstaller line = new LineInstaller();
            line.DrawShapes();

            Point food = FoodFactory.GetRandomFood(119, 20, '*');
            Console.ForegroundColor = ColorHelper.GetRandomColor(new Random().Next(1, 6));
            food.DrawPoint();
            Console.ResetColor();

            Snake snake = new Snake();
            snake.CreateSnake(5, new Point(5, 5, 'z'), Enum.DirectionEnum.Right);
            snake.DrawLine();

            ScoreHelper.GetScore(score);

            while (true)
            {
                if (line.Collision(snake) || snake.CollisionWithOwnTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    score++;
                    ScoreHelper.GetScore(score);

                    food = FoodFactory.GetRandomFood(119, 20, '*');
                    Console.ForegroundColor = ColorHelper.GetRandomColor(new Random().Next(1, 6));
                    food.DrawPoint();
                    Console.ResetColor();
                }

                snake.Move();
                Thread.Sleep(200);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.PressKey(key.Key);
                }
            }
            Concede();
        }

        private void Concede()
        {
            Console.Clear();
            Console.WriteLine("Game over");
            Console.WriteLine("To try again press Enter");
            Console.WriteLine("Back to menu press Backspace");
        }        
    }
}
