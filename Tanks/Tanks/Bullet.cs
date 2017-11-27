﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksClass
{
    public class Bullet : Figures
    {
        const int LENGTH = 9;
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
            this.point = new Point[] { new Point(x0, y0), new Point(x0, y0 - HIGHT), new Point(x0 + LENGTH, y0), new Point(x0, y0 + HIGHT), new Point(x0, y0)};
        }

        /// <summary>
        /// Метод для перемещения снаряда по оси x
        /// </summary>
        public void MoveX()
        {
            this.x0 += speed;
            this.point = new Point[] { new Point(x0, y0), new Point(x0, y0 - HIGHT), new Point(x0 + LENGTH, y0), new Point(x0, y0 + HIGHT), new Point(x0, y0) };
        }

        /// <summary>
        /// Метод перемещения снаряда по оси y
        /// </summary>
        public void MoveY()
        {
            this.y0 += speed;
            this.point = new Point[] { new Point(x0, y0), new Point(x0, y0 - HIGHT), new Point(x0 + LENGTH, y0), new Point(x0, y0 + HIGHT), new Point(x0, y0) };
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