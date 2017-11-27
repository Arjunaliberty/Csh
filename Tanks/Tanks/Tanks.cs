using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksClass
{
    public abstract class Tanks : Figures
    {
        const int LENGTH = 24;
        const int HIGHT = 8;
        public int x0 { get; set; }
        public int y0 { get; set; }
        public int speed { get; set; }
        public int power { get; set; }
        public int armor { get; set; }
        private Color color;
        private GameField gameField = null;
        private Point[] point;

        public Tanks(int x0, int y0, int speed, int power, int armor, Color color, GameField gameField)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.speed = speed;
            this.power = power;
            this.armor = armor;
            this.color = color;
            this.gameField = gameField;
            this.point = new Point[] {new Point(x0, y0), new Point(x0 + LENGTH, y0 + HIGHT), new Point(x0, y0 + 2 * HIGHT), new Point(x0, y0)};
        }

        /// <summary>
        /// Метод для получения координаты x центра ствола
        /// </summary>
        /// <returns></returns>
        private int GetAverageX()
        {
            return x0 + LENGTH;
        }

        /// <summary>
        /// Метод для получения координаты y центра ствола
        /// </summary>
        /// <returns></returns>

        private int GetAverageY()
        {
            return y0 + HIGHT;
        }

        /// <summary>
        /// Метод для премещения танка по оси x
        /// </summary>
        public void MoveX()
        {
            this.x0 += speed;
        }

        /// <summary>
        /// Метод для перемещения танка по оси y
        /// </summary>
        public void MoveY()
        {
            this.y0 += speed;
        }

        /// <summary>
        /// Метод для стрельбы из пушки
        /// </summary>
        public Bullet Fire()
        {
            return new Bullet(GetAverageX(), GetAverageY(), 5, power, 30, color, gameField);
        }

        public override void ShowDraw()
        {
            gameField.graphics.FillPolygon(new SolidBrush(color), point);
        }

        public override void ClearDraw(Color clrColor)
        {
            gameField.graphics.FillPolygon(new SolidBrush(clrColor), point);
        }

        /// <summary>
        /// Метод для передачи в декоратор по виду бонуса
        /// </summary>
        public abstract void TankBonus();
    }
}
