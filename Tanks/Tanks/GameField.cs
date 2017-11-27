﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksClass
{
   public class GameField
    {
        /// <summary>
        /// Свойство для хранения верхней левой координаты x игрового поля
        /// </summary>
        public double minX { get; private set; }

        /// <summary>
        /// Свойство для хранения верхней левой координаты y игрового поля
        /// </summary>
        public double minY { get; private set; }

        /// <summary>
        /// Свойство для хранения нижней правой координаты x игрового поля
        /// </summary>
        public double maxX { get; private set; }

        /// <summary>
        /// Свойство для хранения нижней правой координаты y игрового поля
        /// </summary>
        public double maxY { get; private set; }

        /// <summary>
        /// Поле для хранения цвета игрового поля
        /// </summary>
        public Color color { get; private set; }

        /// <summary>
        /// Поле для хранения канвы игрового поля
        /// </summary>
        public Graphics graphics { get; private set; }

        /// <summary>
        /// Конструктор типа GameField
        /// </summary>
        /// <param name="minX"></param>
        /// <param name="minY"></param>
        /// <param name="maxX"></param>
        /// <param name="maxY"></param>
        /// <param name="color"></param>
        /// <param name="graphics"></param>
        public GameField(double minX, double minY, double maxX, double maxY, Color color, Graphics graphics)
        {
            this.minX = minX;
            this.minY = minY;
            this.maxX = maxX;
            this.maxY = maxY;
            this.color = color;
            this.graphics = graphics;
        }
   }
}
