using System.Drawing;

namespace TanksClass
{
    public class Bullet
    {
        /// <summary>
        /// Константа для хранения раземра снаряда
        /// </summary>
        const int BULLET_LENGHT = 2;

        /// <summary>
        /// Начальная координата x равная координате x ствола танка
        /// </summary>
        public int x0 { get; private set; }
        /// <summary>
        /// Начальная координата y равная координате y ствола танка
        /// </summary>
        public int y0 { get; private set; }
        /// <summary>
        /// Время жизни снаряда time to life
        /// </summary>
        public int ttl { get; set; }
        /// <summary>
        /// Скорость движения снаряда 
        /// </summary>
        public int speed { get; set; }
        /// <summary>
        /// Мощность снаряда
        /// </summary>
        public int power { get; set; }
        /// <summary>
        /// Напрвление движения танка и соответсвенно снаряда
        /// </summary>
        private TankDirect tankDirect { get; set; }

        /// <summary>
        /// Объкт типа танк для доступа к данным о мощности выстрел, направления движения и т.п.
        /// </summary>
        Tank tank = null;
        private Color color;
        private Graphics graphics = null;

        public Bullet(int ttl, int speed, Tank tank)
        {
            this.ttl = ttl;
            this.speed = speed;
            this.x0 = tank.GetXBarell();
            this.y0 = tank.GetYBarell();
            this.power = tank.power; ;
            this.tankDirect = tank.tankDirect;
            this.color = tank.color;
            this.graphics = tank.graphics;
        }

       /// <summary>
       /// Метод отрисовки снаряда
       /// </summary>
        public void ShowBullet()
        {
            if (tankDirect == TankDirect.LEFT)
            {
                graphics.DrawLine(new Pen(color), x0, y0, x0 + BULLET_LENGHT, y0);
            }
            if (tankDirect == TankDirect.RIGHT)
            {
                graphics.DrawLine(new Pen(color), x0, y0, x0 - BULLET_LENGHT, y0);
            }
            if (tankDirect == TankDirect.UP)
            {
                graphics.DrawLine(new Pen(color), x0, y0, x0, y0 - BULLET_LENGHT);
            }
            if (tankDirect == TankDirect.DOWN)
            {
                graphics.DrawLine(new Pen(color), x0, y0, x0, y0 + BULLET_LENGHT);
            }
        }

        /// <summary>
        /// Метод стирания снаряда с экрана
        /// </summary>
        /// <param name="clrColor">Цвет снаряда</param>
        public void ClearBullet(Color clrColor)
        {
            if (tankDirect == TankDirect.LEFT)
            {
                graphics.DrawLine(new Pen(clrColor), x0, y0, x0 + BULLET_LENGHT, y0);
            }
            if (tankDirect == TankDirect.RIGHT)
            {
                graphics.DrawLine(new Pen(clrColor), x0, y0, x0 - BULLET_LENGHT, y0);
            }
            if (tankDirect == TankDirect.UP)
            {
                graphics.DrawLine(new Pen(clrColor), x0, y0, x0, y0 - BULLET_LENGHT);
            }
            if (tankDirect == TankDirect.DOWN)
            {
                graphics.DrawLine(new Pen(clrColor), x0, y0, x0, y0 + BULLET_LENGHT);
            }
        }

        /// <summary>
        /// Метод для перемещения снаряда
        /// </summary>
        public void MoveBullet()
        {
            if (tankDirect == TankDirect.LEFT)
            {
                x0 += speed;
            }
            if (tankDirect == TankDirect.RIGHT)
            {
                x0 -= speed;
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
    }
}
