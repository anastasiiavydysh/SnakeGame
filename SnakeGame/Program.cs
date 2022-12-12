using SnakeGame.Factory;
using SnakeGame.Helpers;
using SnakeGame.Installers;
using SnakeGame.Lines;
using System.Text;

namespace SnakeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.SetWindowSize(120, 30);
            // Console.SetBufferSize(120, 30);
            LineInstaller line = new LineInstaller();
            line.DrawShapes();

            Point food = FoodFactory.GetRandomFood(119,20,'*');
            Console.ForegroundColor = ColorHelper.GetRandomColor(new Random().Next(1,6));
            food.DrawPoint();
            Console.ResetColor();

            Snake snake = new Snake();
            snake.CreateSnake(5, new Point(5, 5, 'z'), Enum.DirectionEnum.Right);
            snake.DrawLine();

            while(true)
            { 
                if(snake.Eat(food))
                {
                    food = FoodFactory.GetRandomFood(119, 20, '*');
                    Console.ForegroundColor = ColorHelper.GetRandomColor(new Random().Next(1, 6));
                    food.DrawPoint();
                    Console.ResetColor();
                }

                snake.Move();
                Thread.Sleep(200);

                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.PressKey(key.Key);
                }
            }            
        }
    }
}