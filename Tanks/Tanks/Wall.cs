using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksClass
{
    public class Wall
    {
        /// <summary>
        /// Константа хранения значения ширины стены
        /// </summary>
        const int WALL_WIDTH = 20;
        /// <summary>
        /// Константа хранения значения высоты стены
        /// </summary>
        const int WALL_HIGHT = 50;

        public int x0 { get; private set; }
        public int y0 { get; private set; }

        private Color color;
        private Graphics graphics = null;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="x0">Координата x верхнего левого угла стены</param>
        /// <param name="y0">Координата y верхнего левого угла стены</param>
        /// <param name="color">Параметр типа Color</param>
        /// <param name="graphics">Параметр типа Graphics</param>
        public Wall(int x0, int y0, Color color, Graphics graphics)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.color = color;
            this.graphics = graphics;
        }

        /// <summary>
        /// Метод отрисовки стены
        /// </summary>
        public void ShowWall()
        {
            graphics.FillRectangle(new SolidBrush(color), x0, y0, WALL_WIDTH, WALL_HIGHT);
        }

        /// <summary>
        /// Метод стирания стены
        /// </summary>
        /// <param name="clrcolor">Параметр определяющий цвет стены</param>
        public void ClearWall(Color clrcolor)
        {
            graphics.FillRectangle(new SolidBrush(clrcolor), x0, y0, WALL_WIDTH, WALL_HIGHT);
        }

        /// <summary>
        /// Метод определения крайней правой координаты x
        /// </summary>
        /// <returns>Возвращает крайнею правую коордтинату x</returns>
        public int FarBoundWallX()
        {
            return x0 + WALL_WIDTH;
        }

        /// <summary>
        /// Метод определения крайней правой координаты y
        /// </summary>
        /// <returns>Возвращает крайнею правую коордтинату y</returns>
        public int FarBoundWallY()
        {
            return y0 + WALL_HIGHT;
        }
    }
}
