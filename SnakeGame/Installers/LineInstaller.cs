﻿using SnakeGame.Lines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Installers
{
    public class LineInstaller
    {
        private List<Shape> _shapes;

        public LineInstaller()
        {
            _shapes = new List<Shape>();

            HorizontalLine topLine = new HorizontalLine(0, 0, '-', 120);
            HorizontalLine downLine = new HorizontalLine(0, 20, '-', 120);
            
            VerticalLine leftLine = new VerticalLine(0, 1, '|', 20);
            VerticalLine rightLine = new VerticalLine(119, 1, '|', 20);

            _shapes.AddRange(new List<Shape> { topLine, downLine, leftLine, rightLine });
        }

        public void DrawShapes()
        {
            foreach(var shape in _shapes)
            {
                shape.DrawLine();
            }
        }

        public bool Collision(Shape shape)
        {
            foreach(var item in _shapes)
            {
                if (item.Collision(shape))
                    return true;
            }
            return false;
        }
    }
}
