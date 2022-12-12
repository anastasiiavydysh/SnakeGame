using SnakeGame.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SnakeGame
{
    public class Snake : Shape
    {
        DirectionEnum direction;
        public Snake()
        {
            points = new List<Point>();
        }

        public Snake CreateSnake(int length, Point snakeTail, DirectionEnum direction)//Singelton
        {
            this.direction = direction;
            for (int i = 0; i < length; i++)
            {
                Point point = new Point(snakeTail);
                point.SetDirection(i, direction);
                points.Add(point);
            }
            return new Snake();
        }

        public void Move()
        {
            Point tail = points.First();
            points.Remove(tail);

            Point head = new Point(points.Last());
            head.SetDirection(1, direction);
            points.Add(head);

            tail.ClearPoint();
            head.DrawPoint();
        }

        public void PressKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    direction = DirectionEnum.Left;
                    break;
                case ConsoleKey.RightArrow:
                    direction = DirectionEnum.Right;
                    break;
                case ConsoleKey.UpArrow:
                    direction = DirectionEnum.Up;
                    break;
                case ConsoleKey.DownArrow:
                    direction = DirectionEnum.Down;
                    break;
            }
        }
        public bool Eat(Point food)
        {
            Point head = new Point(points.Last());
            head.SetDirection(1, direction);

            if (head.ComparePoints(food))
            {
                food.Symbol = head.Symbol;
                points.Add(food);
                return true;
            }
            return false;
        }
    }
}
