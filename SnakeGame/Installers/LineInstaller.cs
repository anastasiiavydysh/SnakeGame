using SnakeGame.Lines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Installers
{
    public class LineInstaller
    {
        private List<Shape> shapes;

        public LineInstaller()
        {
            shapes = new List<Shape>();

            HorizontalLine topLine = new HorizontalLine(0, 0, '-', 120);
            HorizontalLine downLine = new HorizontalLine(0, 20, '-', 120);
            VerticalLine leftLine = new VerticalLine(0, 1, '|', 20);
            VerticalLine rightLine = new VerticalLine(119, 1, '|', 20);

            shapes.AddRange(new List<Shape> { topLine, downLine, leftLine, rightLine });
        }

        public void DrawShapes()
        {
            foreach(var shape in shapes)
            {
                shape.DrawLine();
            }
        }
    }
}
