using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Factory
{
    public static class FoodFactory
    {
        private static Random random = new Random();
        public static Point GetRandomFood(int spaceWidth, int spaceHeight, char symbol)
        {
            spaceWidth = random.Next(2,spaceWidth-2);
            spaceHeight = random.Next(2,spaceHeight-2);
            return new Point(spaceWidth, spaceHeight, symbol);
        }
    }
}
