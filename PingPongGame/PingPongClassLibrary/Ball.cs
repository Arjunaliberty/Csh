using System;
using System.Drawing;

namespace PingPongClassLibrary
{
    public class Ball
    {
        /// <summary>
        /// Свойства для хранения координа центра (x,y) и радиуса (r) шарика
        /// </summary>
        public int x { get; set; }
        public int y { get; set; }
        public int r { get; set; }

        /// <summary>
        /// Свойство для хранения цвета шарика
        /// </summary>
        private Color color;

        /// <summary>
        /// Свойстов для хранени скорости передвижения шарика
        /// </summary>
        public int speed { get; private set; }

        /// <summary>
        /// Поле для хранения объекта типа GameField (игровое поле)
        /// </summary>
        private GameField gameField;

        /// <summary>
        /// k - коэффициент наклона прямой
        /// </summary>
        public double k { get; set; } // y=k*x+b

        /// <summary>
        /// b - константа
        /// </summary>
        public double b { get;  set; }

        public Ball(int x, int y, int r, Color color, int speed, GameField gameField, double k, double b)
        {
            this.x = x;
            this.y = y;
            this.r = r;
            this.color = color;
            this.speed = speed;
            this.gameField = gameField;
            this.k = k;
            this.b = b;
        }

        /// <summary>
        /// Метод отрисовки шарика
        /// </summary>
        public void Draw()
        {
            gameField.graphics.FillEllipse(new SolidBrush(color), 
                x - r, y - r, 2 * r, 2 * r);
        }

        /// <summary>
        /// Метод для стирания изображения шарика с экрана
        /// </summary>
        public void ClearDraw()
        {
            gameField.graphics.FillEllipse(new SolidBrush(gameField.color),
                x - r, y - r, 2 * r, 2 * r);
        }

        /// <summary>
        /// Получения координаты x из уравнения прямой
        /// </summary>
        /// <returns>Возвращает координату x прямой</returns>
        private double X()
        {
            return (y - b) / k;
        }

        /// <summary>
        /// Получения координаты y из уравнения прямой
        /// </summary>
        /// <returns name = "y"> Возвращает координату y </returns>
        private double Y()
        {
            return k * x + b;
        }
       
        /// <summary>
        /// Метод проверяет вышла ли координа (x) шарика за левый предел игрового поля
        /// </summary>
        /// <returns> Возвращает true если вышла и false если нет </returns>
        public bool CheckMinX()
        {
            if (this.x <= gameField.minX)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Метод для проверки вышла ли координата (x) шарика за правый предел игрового поля
        /// </summary>
        /// <returns> Возвращает true если вышла и false если нет </returns>
        public bool CheckMaxX()
        {
            if (this.x >= gameField.maxX)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Метод проверяет вышла ли координа (y) шарика за верхний предел игрового поля
        /// </summary>
        /// <returns> Возвращает true если вышла и false если нет </returns>
        public bool CheckMinY()
        {
            if (this.y - this.r <= gameField.minY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Метод проверяет вышла ли координа (y) шарика за нижний предел игрового поля
        /// </summary>
        /// <returns> Возвращает true если вышла и false если нет </returns>
        public bool CheckMaxY()
        {
            if (this.y + this.r >= gameField.maxY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Метод проверяет пересеклись ли координаты шарика с координатами ракетки 
        /// </summary>
        /// <param name="racketPad"> Объект типа RacketPad </param>
        /// <returns> Возвращает true если вышла и false если нет </returns>
        public bool CheckPad(RacketPad racketPad)
        {
            if(((this.y <= (racketPad.y + racketPad.height)) && (this.y >= racketPad.y)) && ((this.x - this.r == racketPad.x) || (this.x + this.r == (racketPad.x+racketPad.width))))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Метод для передвижения шарика
        /// </summary>
        /// <param name="pads"> Передается массив объектов типа RacketPad </param>
        public void Move(params RacketPad[] pads)
        {
            x += speed;
            y = (int)Y();

            //if (CheckMinX() || CheckMaxX())
            //{
            //    k = -k;
            //    b = y - (k * x);
            //    speed = -speed;
            //}

            // Проверяем выходит ли координата у за пределы верхней или нижней границы поля
            // И меняем движение на противополжное
            if (CheckMinY() || CheckMaxY())
            {
                k = -k;
                b = y - (k * x);
            }

            // Проверяем пересеклись ли координаты мячика и ракетки если пересеклись, 
            // То меняем движение на противополжное
            if (CheckPad(pads[0]) || CheckPad(pads[1]))
            {
                k = -k;
                b = y - (k * x);
                speed = -speed;
            }

        }
    }
}
