using System;
using System.Drawing;

namespace PingPongClassLibrary
{
    public class GameField
    {
        public int minX {get;set;}
        public int maxX { get; set;}

        public int minY { get; set; }
        public int maxY { get; set; }

        public Graphics graphics { get; set; }

        public Color color { get; set; }

        public GameField(int minX, int minY, int maxX, int maxY, Color color, Graphics graphics)
        {
            this.minX = minX;
            this.minY = minY;
            this.maxX = maxX;
            this.maxY = maxY;
            this.color = color;
            this.graphics = graphics;
        }
    }
}
