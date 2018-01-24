using System;
using System.Drawing;

namespace ClassLibrary1
{
    public abstract class Figure
    {
        protected Graphics gameField;
        protected int maxX, maxY;
        protected Color color; 

        public int leftUpX { get; set; }
        public int leftUpY { get; set; }
        public int rightDownX { get; set; }
        public int rightDownY { get; set; }

        public int TTL { get; set; }

       
        public Figure(int leftUpX, int leftUpY, int rightDownX, 
            int rightDownY, int TTL, Color color,
            int maxX, int maxY, Graphics gameField)
        {
            this.leftUpX = leftUpX;
            this.leftUpY = leftUpY;
            this.rightDownX = rightDownX;
            this.rightDownY = rightDownY;
            this.TTL = TTL;
            this.color = color;
            this.maxX = maxX;
            this.maxY = maxY;
            this.gameField = gameField;
        }

        public void MoveDown()
        {
            if (rightDownY<maxY)
            {
                leftUpY++;
                rightDownY++;
            }
            
        }

        public abstract int GetPoint();
        public abstract void Draw();
        public abstract void ClearDraw(Color clrColor);
        public abstract bool CheckPoint(int X, int Y);




    }
}
