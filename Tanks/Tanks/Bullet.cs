using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksClass
{
    public class Bullet : Figures
    {
        const int WIDTH = 9;
        const int HIGHT = 3;
        public int x0 { get; private set; }
        public int y0 { get; private set; }
        public int speed { get; set; }
        public int power { get; private set; }
        public int ttl { get; set; }
        private Color color;
        private GameField gameField = null;
        private Point[] point;

        public Bullet(int x0, int y0, int speed, int power, int ttl, Color color, GameField gameField)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.speed = speed;
            this.power = power;
            this.ttl = ttl;
            this.color = color;
            this.gameField = gameField;
            this.point = new Point[] { new Point(x0, y0), new Point(x0, y0 - HIGHT), new Point(x0 + WIDTH, y0), new Point(x0, y0 + HIGHT), new Point(x0, y0)};
        }

        /// <summary>
        /// Метод для перемещения снаряда по оси x
        /// </summary>
        public void MoveX()
        {
            this.x0 += speed;
            this.point = new Point[] { new Point(x0, y0), new Point(x0, y0 - HIGHT), new Point(x0 + WIDTH, y0), new Point(x0, y0 + HIGHT), new Point(x0, y0) };
        }

        /// <summary>
        /// Метод перемещения снаряда по оси y
        /// </summary>
        public void MoveY()
        {
            this.y0 += speed;
            this.point = new Point[] { new Point(x0, y0), new Point(x0, y0 - HIGHT), new Point(x0 + WIDTH, y0), new Point(x0, y0 + HIGHT), new Point(x0, y0) };
        }

        /// <summary>
        /// Метод для определения координаты x крайней точки снаряда
        /// </summary>
        /// <returns>Возвращает координату x крайней точки снаряда</returns>
        private int GetAverageX()
        {
            return x0 + WIDTH;
        }

        /// <summary>
        /// Метод для определения координаты y крайней точки снаряда
        /// </summary>
        /// <returns>Возвращает координату y крайней точки снаряда</returns>

        public int GetAverageY()
        {
            return y0;
        }

        /// <summary>
        /// Метод для проверки пересечения координат снаряда с другими объктами
        /// </summary>
        /// <returns></returns>
        public bool CheckBullet(Figures figures)
        {
            // Проверяем является ли переданный объект стеной
            if (figures is Wall)
            {
                if (((GetAverageX() >= ((Wall)figures).x0) && ((GetAverageX() <= ((Wall)figures).x0 + ((Wall)figures).GetWidth()))) && 
                   ((y0 >= ((Wall)figures).y0) && (y0 <= ((Wall)figures).y0 + ((Wall)figures).GetHight())))
                {
                    return true;
                }
            }

            // Проверяем является ли переданный объект бонусом
            if (figures is Bonus)
            {
                if (((GetAverageX() >= ((Bonus)figures).x0) && ((GetAverageX() <= ((Bonus)figures).x0 + ((Bonus)figures).GetWidth()))) &&
                   ((y0 >= ((Bonus)figures).y0) && (y0 <= ((Bonus)figures).y0 + ((Bonus)figures).GetHight())))
                {
                    return true;
                }
            }

            // Проверяем является ли объект танком
            if (figures is Tanks)
            {
                if (((GetAverageX() >= ((Tanks)figures).x0) && ((GetAverageX() <= ((Tanks)figures).x0 + ((Tanks)figures).GetWidth()))) &&
                   ((y0 >= ((Tanks)figures).y0) && (y0 <= ((Tanks)figures).y0 + ((Tanks)figures).GetHight())))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Метод отрисовки снаряда на экране
        /// </summary>
        public override void ShowDraw()
        {
            gameField.graphics.FillPolygon(new SolidBrush(color), point);
        }

        /// <summary>
        /// Метод стирания снаряда с экрана
        /// </summary>
        /// <param name="clrColor"></param>
        public override void ClearDraw(Color clrColor)
        {
            gameField.graphics.FillPolygon(new SolidBrush(clrColor), point);
        }
    }
}
