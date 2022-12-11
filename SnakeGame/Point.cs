using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Point
    {
        int left, top;
        char symbol;

        public Point(int left, int top, char symbol)
        {
            this.left = left;
            this.top = top;
            this.symbol = symbol;
        }

        public void DrawPoint()
        {
            Console.SetCursorPosition(left, top);
            Console.Write(symbol);
        }
    }
}
