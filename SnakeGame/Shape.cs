using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Shape
    {
        protected List<Point> points;

        public void DrawLine()
        {
            foreach (var point in this.points)
            {
                point.DrawPoint();
            }
        }
    }
}
