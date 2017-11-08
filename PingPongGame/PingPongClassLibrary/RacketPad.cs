using System;
using System.Drawing;

namespace PingPongClassLibrary
{
    public class RacketPad
    {
        public int x { get; set; }
        public int y { get; set; }

        public int width { get; set; }

        public int height { get; set; }

        private Color color;

        private int speed;

        private GameField gameField;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="x"> Координата (x) левого верхнего угла ракетки </param>
        /// <param name="y"> Координата (y) левого верхнего угла ракетки </param>
        /// <param name="width"> Толщина ракетки </param>
        /// <param name="height"> Высота ракетки </param>
        /// <param name="color"> Цвет ракетки </param>
        /// <param name="speed"> Скорость передвижения ракетки </param>
        /// <param name="gameField"> Конва игрового поля </param>
        public RacketPad(int x, int y, int width, int height, Color color, int speed, GameField gameField)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.color = color;
            this.speed = speed;
            this.gameField = gameField;
        }
        /// <summary>
        /// Метод для пермещения ракетки вверх
        /// </summary>
        public void MoveUp()
        {
            y-=speed;
            if (y<gameField.minY) { y = gameField.minY; }
        }

        /// <summary>
        /// Метод для перемещения ракетки вниз
        /// </summary>
        public void MoveDown()
        {
            y += speed;
            if ((y+height) > gameField.maxY)
               { y = gameField.maxY - height; }
        }

        /// <summary>
        /// Метод для отрисовки ракетки
        /// </summary>
        public void Draw()
        {
            gameField.graphics.FillRectangle(new SolidBrush(color), x, y, width, height);
        }

        /// <summary>
        /// Метод для стирания ракетки
        /// </summary>
        public void ClearDraw()
        {
            gameField.graphics.FillRectangle(new SolidBrush(gameField.color), x, y, width, height);
        }
    }
}
