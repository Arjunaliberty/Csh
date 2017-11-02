using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClicker
{
    public class Quadrate : Figure
    {
        public Quadrate(int leftUpX, int leftUpY, int rightDownX, int rightDownY, int ttl, int maxX, int maxY, int direct, Color color, Graphics gameField) :
               base (leftUpX, leftUpY, rightDownX, rightDownY, ttl, maxX, maxY, direct, color, gameField)
        {

        }
        // Реализация абстрактного метода класса Figure возвращающий количество очков при попадании на фигуру
        public override int GetScore()
        {
            return 10;
        }
        // Реализация абстрактного метода класса Figure проверающий входят ли координаты мыши в область фигуры
        public override bool CheckPoint(int X, int Y)
        {
            // Координаты середины фигуры
            int x0, y0, r;
            // Определяем координаты середины и радиус
            x0 = (leftUpX + rightDownX) / 2;
            y0 = (leftUpY + rightDownY) / 2;
            r = (rightDownX - leftUpX) / 2;

            if (Math.Abs(X - x0) < r && Math.Abs(Y - y0) < r)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Реализация метода отрисовки фигуры
        public override void Draw()
        {
            int r = rightDownX - leftUpX;
            gameField.FillRectangle(new SolidBrush(color), leftUpX, leftUpY, r, r);
        }
        // реализация метода стирания фигуры
        public override void ClearDraw(Color clrColor)
        {
            int r = rightDownX - leftUpX;
            gameField.FillRectangle(new SolidBrush(clrColor), leftUpX, leftUpY, r, r);
        }
    }
}
