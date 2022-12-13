using SnakeGame.Enum;

namespace SnakeGame
{
    public class Snake : Shape
    {
        DirectionEnum direction;
        public Snake()
        {
            _points = new List<Point>();
        }

        public void CreateSnake(int length, Point snakeTail, DirectionEnum direction)//Singelton
        {
            this.direction = direction;
            for (int i = 0; i < length; i++)
            {
                Point point = new Point(snakeTail);
                point.SetDirection(i, direction);
                _points.Add(point);
            }
        }

        public void Move()
        {
            Point tail = _points.First();
            _points.Remove(tail);

            Point head = new Point(_points.Last());
            head.SetDirection(1, direction);
            _points.Add(head);

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
            Point head = new Point(_points.Last());
            head.SetDirection(1, direction);

            if (head.ComparePoints(food))
            {
                food.Symbol = head.Symbol;
                _points.Add(food);
                return true;
            }
            return false;
        }

        public bool CollisionWithOwnTail()
        {
            Point head = _points.Last();
            for (int i = 0; i < _points.Count - 1; i++)
            {
                if (head.ComparePoints(_points[i]))
                    return true;
            }
            return false;
        }
    }
}
