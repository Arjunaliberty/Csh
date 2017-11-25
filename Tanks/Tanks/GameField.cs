using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksClass
{
   public class GameField
    {

        public double minX { get; set; }
        public double minY { get; set; }
        public double maxX { get; set; }
        public double maxY { get; set; }
        public Color color { get; set; }
        public Graphics graphics { get; set; }


        Tank tank1;
        Tank tank2;
        Bullet bullet1;
        Bullet bullet2;
        List<Wall> wall;
        List<Bonus> List;

        public GameField(double minX, double minY, double maxX, double maxY, Color color, Graphics graphics)
        {
            this.minX = minX;
            this.minY = minY;
            this.maxX = maxX;
            this.maxY = maxY;
            this.color = color;
            this.graphics = graphics;
        }

        /// <summary>
        /// Метод проверяет вышла ли граница танка за координаты игрового поля
        /// </summary>
        /// <param name="tank"></param>
        /// <returns>Возвращает true если коодинаты x или y танка выходят за границы игрового поля</returns>
        private bool OutputBoundGameField(Tank tank)
        {
            if ((tank.GetXBarell() <= this.minX) || (tank.GetXBarell() >= this.maxX) || (tank.GetYBarell() <= this.minY) || (tank.GetYBarell() >= this.maxY))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool OutputBoundWall(Tank tank)
        {
            if ((tank.GetXBarell() >= wall.))
            {
                return true;
            }
            else
            {
                return false;
            }
        }










    }
}
