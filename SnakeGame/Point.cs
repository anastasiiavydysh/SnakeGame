using SnakeGame.Enum;

namespace SnakeGame
{
    public class Point
    {
        int left, top;
        char symbol;

        public char Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        public Point(Point snakeTail)
        {
            this.left = snakeTail.left;
            this.top = snakeTail.top;
            this.symbol = snakeTail.symbol;
        }

        public Point(int left, int top, char symbol)
        {
            this.left = left;
            this.top = top;
            this.symbol = symbol;
        }

        public void DrawPoint()
        {
            Console.SetCursorPosition(this.left, this.top);
            Console.Write(this.symbol);
        }

        public void SetDirection(int i, DirectionEnum direction)
        {
            switch (direction)
            {
                case DirectionEnum.Left:
                    this.left -= i;
                    break;
                case DirectionEnum.Right:
                    this.left += i;
                    break;
                case DirectionEnum.Up:
                    this.top -= i;
                    break;
                case DirectionEnum.Down:
                    this.top += i;
                    break;
            }
        }

        public void ClearPoint()
        {
            symbol = ' ';
            DrawPoint();
        }

        public bool ComparePoints(Point point)
        {
            return point.left == left && point.top == top;
        }
    }
}
