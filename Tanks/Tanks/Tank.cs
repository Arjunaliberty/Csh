using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksClass
{
    public enum TankDirect
    {
        LEFT,
        RIGHT,
        UP,
        DOWN
    }

    public abstract class Tank
    {
        const int TRACK_WIDTH = 40;
        const int TRACK_HIGHT = 10;
        const int TOWER_WIDTH = 20;
        const int TOWER_HIGHT = 20;
        const int BARREL = 10;
        
        /// <summary>
        /// Краняя левая верхняя координата по оси x
        /// </summary>
        public int x0 { get; set; }
        /// <summary>
        /// Крайняя левая верняя координата по оси y
        /// </summary>
        public int y0 { get; set; }
        /// <summary>
        /// Свойство для хранения толщины брони танка
        /// </summary>
        public int armor { get; set; }
        /// <summary>
        /// Скорость передвижения танчика
        /// </summary>
        public int speed { get; set; }
        /// <summary>
        /// Мощность выстрела танка
        /// </summary>
        public int power { get; set; }
        /// <summary>
        /// Направление танка
        /// </summary>
        public TankDirect tankDirect { get; set; }
        /// <summary>
        /// Свойство для хранения цвета танчика
        /// </summary>
        public Color color { get; set; }
        /// <summary>
        /// Создаем поверхность рисования танчика
        /// </summary>
        public Graphics graphics { get; set; }

        /// <summary>
        /// Конструктор для объектов типа Tank
        /// </summary>
        public Tank(int x, int y, int armor, int speed, int power, TankDirect tankDirect, Color color, Graphics graphics)
        {
            this.x0 = x;
            this.y0 = y;
            this.armor = armor;
            this.speed = speed;
            this.power = power;
            this.tankDirect = tankDirect;
            this.color = color;
            this.graphics = graphics;
        }
        
        /// <summary>
        /// Мтод отрисовки танка на экране
        /// </summary>
        public void ShowTanks()
        {
            if (tankDirect == TankDirect.LEFT)
            {
                graphics.FillRectangle(new SolidBrush(color), x0, y0, TRACK_WIDTH, TRACK_HIGHT);
                graphics.FillRectangle(new SolidBrush(color), x0 + TRACK_WIDTH / 4, y0 + TRACK_HIGHT, TOWER_WIDTH, TOWER_HIGHT);
                graphics.FillRectangle(new SolidBrush(color), x0, y0 + TRACK_HIGHT + TOWER_HIGHT, TRACK_WIDTH, TRACK_HIGHT);
                graphics.DrawLine(new Pen(color), x0 + TRACK_WIDTH / 4, y0 + TRACK_HIGHT + TOWER_HIGHT / 2, x0 + TRACK_WIDTH / 4 - BARREL, y0 + TRACK_HIGHT + TOWER_HIGHT / 2);
            }
            if (tankDirect == TankDirect.RIGHT)
            {
                graphics.FillRectangle(new SolidBrush(color), x0, y0, TRACK_WIDTH, TRACK_HIGHT);
                graphics.FillRectangle(new SolidBrush(color), x0 + TRACK_WIDTH / 4, y0 + TRACK_HIGHT, TOWER_WIDTH, TOWER_HIGHT);
                graphics.FillRectangle(new SolidBrush(color), x0, y0 + TRACK_HIGHT + TOWER_HIGHT, TRACK_WIDTH, TRACK_HIGHT);
                graphics.DrawLine(new Pen(color), x0 + TOWER_WIDTH + TRACK_WIDTH / 4, y0 + TRACK_HIGHT + TOWER_HIGHT / 2, x0 + TOWER_WIDTH  + TRACK_WIDTH/ 4 + BARREL, y0 + TRACK_HIGHT + TOWER_HIGHT / 2);
            }
            if (tankDirect == TankDirect.UP)
            {
                graphics.FillRectangle(new SolidBrush(color), x0, y0, TRACK_HIGHT, TRACK_WIDTH);
                graphics.FillRectangle(new SolidBrush(color), x0 + TRACK_HIGHT, y0 + TRACK_WIDTH / 4, TOWER_HIGHT, TOWER_WIDTH);
                graphics.FillRectangle(new SolidBrush(color), x0 + TRACK_HIGHT + TOWER_HIGHT, y0, TRACK_HIGHT, TRACK_WIDTH);
                graphics.DrawLine(new Pen(color), x0 + TRACK_HIGHT + TOWER_HIGHT / 2, y0 + TRACK_WIDTH / 4, x0 + TRACK_HIGHT + TOWER_HIGHT / 2, y0 + TRACK_WIDTH / 4 - BARREL);
            }
            if (tankDirect == TankDirect.DOWN)
            {
                graphics.FillRectangle(new SolidBrush(color), x0, y0, TRACK_HIGHT, TRACK_WIDTH);
                graphics.FillRectangle(new SolidBrush(color), x0 + TRACK_HIGHT, y0 + TRACK_WIDTH / 4, TOWER_HIGHT, TOWER_WIDTH);
                graphics.FillRectangle(new SolidBrush(color), x0 + TRACK_HIGHT + TOWER_HIGHT, y0, TRACK_HIGHT, TRACK_WIDTH);
                graphics.DrawLine(new Pen(color), x0 + TRACK_HIGHT + TOWER_HIGHT / 2, y0 + TRACK_WIDTH - TRACK_WIDTH / 4, x0 + TRACK_HIGHT + TOWER_HIGHT / 2, y0 + TRACK_WIDTH - TRACK_WIDTH / 4 + BARREL);
            }
        }
       
        /// <summary>
        /// Метод по стиранию танка с экрана
        /// </summary>
        /// <param name="clrColor">Цвет фона формы</param>
        public void ClearTanks(Color clrColor)
        {
            if (tankDirect == TankDirect.LEFT)
            {
                graphics.FillRectangle(new SolidBrush(clearColor), x0, y0, TRACK_WIDTH, TRACK_HIGHT);
                graphics.FillRectangle(new SolidBrush(clearColor), x0 + TRACK_WIDTH / 4, y0 + TRACK_HIGHT, TOWER_WIDTH, TOWER_HIGHT);
                graphics.FillRectangle(new SolidBrush(clearColor), x0, y0 + TRACK_HIGHT + TOWER_HIGHT, TRACK_WIDTH, TRACK_HIGHT);
                graphics.DrawLine(new Pen(clearColor), x0 + TRACK_WIDTH / 4, y0 + TRACK_HIGHT + TOWER_HIGHT / 2, x0 + TRACK_WIDTH / 4 - BARREL, y0 + TRACK_HIGHT + TOWER_HIGHT / 2);
            }
            if (tankDirect == TankDirect.RIGHT)
            {
                graphics.FillRectangle(new SolidBrush(clearColor), x0, y0, TRACK_WIDTH, TRACK_HIGHT);
                graphics.FillRectangle(new SolidBrush(clearColor), x0 + TRACK_WIDTH / 4, y0 + TRACK_HIGHT, TOWER_WIDTH, TOWER_HIGHT);
                graphics.FillRectangle(new SolidBrush(clearColor), x0, y0 + TRACK_HIGHT + TOWER_HIGHT, TRACK_WIDTH, TRACK_HIGHT);
                graphics.DrawLine(new Pen(clearColor), x0 + TOWER_WIDTH + TRACK_WIDTH / 4, y0 + TRACK_HIGHT + TOWER_HIGHT / 2, x0 + TOWER_WIDTH + TRACK_WIDTH / 4 + BARREL, y0 + TRACK_HIGHT + TOWER_HIGHT / 2);
            }
            if (tankDirect == TankDirect.UP)
            {
                graphics.FillRectangle(new SolidBrush(clearColor), x0, y0, TRACK_HIGHT, TRACK_WIDTH);
                graphics.FillRectangle(new SolidBrush(clearColor), x0 + TRACK_HIGHT, y0 + TRACK_WIDTH / 4, TOWER_HIGHT, TOWER_WIDTH);
                graphics.FillRectangle(new SolidBrush(clearColor), x0 + TRACK_HIGHT + TOWER_HIGHT, y0, TRACK_HIGHT, TRACK_WIDTH);
                graphics.DrawLine(new Pen(clearColor), x0 + TRACK_HIGHT + TOWER_HIGHT / 2, y0 + TRACK_WIDTH / 4, x0 + TRACK_HIGHT + TOWER_HIGHT / 2, y0 + TRACK_WIDTH / 4 - BARREL);
            }
            if (tankDirect == TankDirect.DOWN)
            {
                graphics.FillRectangle(new SolidBrush(clearColor), x0, y0, TRACK_HIGHT, TRACK_WIDTH);
                graphics.FillRectangle(new SolidBrush(clearColor), x0 + TRACK_HIGHT, y0 + TRACK_WIDTH / 4, TOWER_HIGHT, TOWER_WIDTH);
                graphics.FillRectangle(new SolidBrush(clearColor), x0 + TRACK_HIGHT + TOWER_HIGHT, y0, TRACK_HIGHT, TRACK_WIDTH);
                graphics.DrawLine(new Pen(clearColor), x0 + TRACK_HIGHT + TOWER_HIGHT / 2, y0 + TRACK_WIDTH - TRACK_WIDTH / 4, x0 + TRACK_HIGHT + TOWER_HIGHT / 2, y0 + TRACK_WIDTH - TRACK_WIDTH / 4 + BARREL);
            }
        }

        /// <summary>
        /// Метод для перемещения танка
        /// </summary>
        public void MoveTank()
        {
            if (tankDirect == TankDirect.LEFT)
            {
                x0 -= speed;
            }
            if (tankDirect == TankDirect.RIGHT)
            {
                x0 += speed;
            }
            if (tankDirect == TankDirect.UP)
            {
                y0 -= speed;
            }
            if (tankDirect == TankDirect.DOWN)
            {
                y0 += speed;
            }
        }

        /// <summary>
        /// Метод для определения координаты x ствола танка
        /// </summary>
        /// <returns>Возвращает координату х ствола танка  или null если координата не определена</returns>
        public int? GetXBarell()
        {
            int? result = null;

            if (tankDirect == TankDirect.LEFT)
            {
                result =  x0 + TRACK_WIDTH / 4 - BARREL;
            }
            if (tankDirect == TankDirect.RIGHT)
            {
                result =  x0 + TOWER_WIDTH + TRACK_WIDTH / 4 + BARREL;
            }
            if (tankDirect == TankDirect.UP)
            {
                result = x0 + TRACK_HIGHT + TOWER_HIGHT / 2;
            }
            if (tankDirect == TankDirect.DOWN)
            {
                result = x0 + TRACK_HIGHT + TOWER_HIGHT / 2;
            }

            return result;
        }

        /// <summary>
        /// Метод для определения координаты y ствола танка
        /// </summary>
        /// <returns>Возвращает координату y ствола танка или null если координата не определена</returns>
        public int? GetYBarell()
        {
            int? result = null;

            if (tankDirect == TankDirect.LEFT)
            {
                result = y0 + TRACK_HIGHT + TOWER_HIGHT / 2;
            }
            if (tankDirect == TankDirect.RIGHT)
            {
                result = y0 + TRACK_HIGHT + TOWER_HIGHT / 2;
            }
            if (tankDirect == TankDirect.UP)
            {
                result = y0 + TRACK_WIDTH / 4 - BARREL;
            }
            if (tankDirect == TankDirect.DOWN)
            {
                result = y0 + TRACK_WIDTH - TRACK_WIDTH / 4 + BARREL;
            }

            return result;
        }

        /// <summary>
        /// Абстракный метод для увеличения или уменьшения бонуса
        /// </summary>
        public abstract void Bonus();
    }
}
