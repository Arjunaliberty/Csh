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
        const int WIDTH = 24;
        const int HIGHT = 8;
        // Время действия бонуса
        public int ttlBonus { get; set; }

        public int x0 { get; set; }
        public int y0 { get; set; }
        public int speed { get; set; }
        public int power { get; set; }
        public int armor { get; set; }
        public Color color;
        public GameField gameField = null;
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
            this.point = new Point[] {new Point(x0, y0), new Point(x0 + WIDTH, y0 + HIGHT), new Point(x0, y0 + 2 * HIGHT), new Point(x0, y0)};
        }

        /// <summary>
        /// Метод возвращающий ширину танка
        /// </summary>
        /// <returns></returns>
        public int GetWidth()
        {
            return WIDTH;
        }

        /// <summary>
        /// Метод возвращает высоту танка
        /// </summary>
        /// <returns></returns>
        public int GetHight()
        {
            return HIGHT;
        }

        /// <summary>
        /// Метод для получения координаты x центра ствола
        /// </summary>
        /// <returns></returns>
        private int GetAverageX()
        {
            return x0 + WIDTH;
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
        public void MoveRightX()
        {
            this.x0 += speed;
            this.point = new Point[] { new Point(x0, y0), new Point(x0 + WIDTH, y0 + HIGHT), new Point(x0, y0 + 2 * HIGHT), new Point(x0, y0) };
        }

        public void MoveLeftX()
        {
            this.x0 -= speed;
            this.point = new Point[] { new Point(x0, y0), new Point(x0 + WIDTH, y0 + HIGHT), new Point(x0, y0 + 2 * HIGHT), new Point(x0, y0) };
        }

        /// <summary>
        /// Метод для перемещения танка по оси y
        /// </summary>
        public void MoveDowbY()
        {
            this.y0 += speed;
            this.point = new Point[] { new Point(x0, y0), new Point(x0 + WIDTH, y0 + HIGHT), new Point(x0, y0 + 2 * HIGHT), new Point(x0, y0) };
        }

        public void MoveUpY()
        {
            this.y0 -= speed;
            this.point = new Point[] { new Point(x0, y0), new Point(x0 + WIDTH, y0 + HIGHT), new Point(x0, y0 + 2 * HIGHT), new Point(x0, y0) };
        }

        /// <summary>
        /// Метод для стрельбы из пушки
        /// </summary>
        public Bullet Fire()
        {
            return new Bullet(GetAverageX(), GetAverageY(), 5, power, 30, color, gameField);
        }

        /// <summary>
        /// Перегрузка метода для проверки проверки координа танка
        /// </summary>
        /// <param name="figure"></param>
        /// <returns></returns>
        public bool CheckTanks(Figures figures)
        {
            //if (figures is Wall)
            //{
            //    if (((GetAverageX() >= ((Wall)figures).x0) && ((GetAverageX() <= ((Wall)figures).x0 && GetAverageX() >= ((Wall)figures).GetWidth()))) && 
            //       ((GetAverageY() >= ((Wall)figures).y0) && (GetAverageY() <= ((Wall)figures).y0 + ((Wall)figures).GetHight())))
            //    {
            //        return true;
            //    }
            //}
            if (figures is Bonus)
            {
                if (((GetAverageX() >= ((Bonus)figures).x0) && ((GetAverageX() <= ((Bonus)figures).x0 + ((Bonus)figures).GetWidth()))) &&
                   ((GetAverageY() >= ((Bonus)figures).y0) && (GetAverageY() <= ((Bonus)figures).y0 + ((Bonus)figures).GetHight())))
                {
                    return true;
                }
            }
            //if (figures is Tanks)
            //{
            //    if (((GetAverageX() >= ((Tanks)figures).x0) && ((GetAverageX() <= ((Tanks)figures).x0 && GetAverageX() >= ((Tanks)figures).GetWidth()))) &&
            //       ((GetAverageY() >= ((Tanks)figures).y0) && (GetAverageY() <= ((Tanks)figures).y0 + ((Tanks)figures).GetHight())))
            //    {
            //        return true;
            //    }
            //}

            return false;
        }

        /// <summary>
        /// Метод для провекрки координат танка при выходе за границу игрового поля
        /// </summary>
        /// <param name="gameField"></param>
        /// <returns></returns>
        public bool CheckBoundRight()
        {
            if (GetAverageX() >= gameField.maxX) return true;
            return false;
        }
        public bool CheckBoundLeft()
        {
            if (x0 <= gameField.minX) return true;
            return false;
        }
        public bool CheckBoundUp()
        {
            if (y0 <= gameField.minY) return true;
            return false;
        }
        public bool CheckBoundDown()
        {
            if (GetAverageY() + HIGHT >= gameField.maxY)  return true;
            return false;
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
