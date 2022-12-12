using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Lines
{
    public class VerticalLine: Shape
    {        
        public VerticalLine(int left, int top, char symbol, int count)
        {
            this.points = new List<Point>();
            for (int i = top; i < count; i++)
            {
                Point point = new Point(left, i, symbol);
                this.points.Add(point);
            }
        }
    }
}
