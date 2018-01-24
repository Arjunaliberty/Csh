using System;
using System.Drawing;


namespace ClassLibrary1
{
    public class Circle : Figure
    {
        public Circle(int leftUpX, int leftUpY, int rightDownX,
            int rightDownY, int TTL, Color color,
            int maxX, int maxY, Graphics gameField) : 
            base(leftUpX, leftUpY, rightDownX, rightDownY, 
                 TTL, color, maxX, maxY, gameField)
        {

        }

        public override bool CheckPoint(int X, int Y)
        {
            int x0, y0, r;

            x0 = (leftUpX + rightDownX) / 2;
            y0 = (leftUpY + rightDownY) / 2;
            r = (rightDownX - leftUpX) / 2;

            if ((Math.Pow(X-x0,2)+ Math.Pow(Y-y0, 2)) <=Math.Pow(r,2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void ClearDraw(Color clrColor)
        {
            int r = rightDownX - leftUpX;
            gameField.FillEllipse(new SolidBrush(clrColor), leftUpX, leftUpY, r, r);
        }

        public override void Draw()
        {
            int r = rightDownX - leftUpX;
            gameField.FillEllipse(new SolidBrush(color), leftUpX, leftUpY, r, r);
        }

        public override int GetPoint()
        {
            return 5;
        }
    }
}
