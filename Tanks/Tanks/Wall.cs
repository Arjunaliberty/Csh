using System;
using System.Drawing;

namespace TanksClass
{
    public class Wall : Figures
    {
        /// <summary>
        /// Константа хранения значения ширины стены
        /// </summary>
        const int WIDTH = 10;
        
        /// <summary>
        /// Константа хранения значения высоты стены
        /// </summary>
        const int HIGHT = 50;

        /// <summary>
        /// Верхняя левая координата x стены
        /// </summary>
        public int x0 { get; private set; }

        /// <summary>
        /// Верхняя левая координата y стены
        /// </summary>
        public int y0 { get; private set; }

        /// <summary>
        /// Поле для хранения цвета стены
        /// </summary>
        private Color color;

        private GameField gameField = null;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="x0">Координата x верхнего левого угла стены</param>
        /// <param name="y0">Координата y верхнего левого угла стены</param>
        /// <param name="color">Параметр типа Color</param>
        /// <param name="gameField">Параметр типа GameField</param>
        public Wall(int x0, int y0, Color color, GameField gameField)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.color = color;
            this.gameField = gameField;
        }

        /// <summary>
        /// Метод возвращает ширину стены
        /// </summary>
        /// <returns></returns>
        public int GetWidth()
        {
            return WIDTH;
        }

        /// <summary>
        /// Метод возвращает высоту стены
        /// </summary>
        /// <returns></returns>
        public int GetHight()
        {
            return HIGHT;
        }

        /// <summary>
        /// Реализация метода по отрисовке стены на экране
        /// </summary>
        public override void ShowDraw()
        {
            gameField.graphics.FillRectangle(new SolidBrush(color), x0, y0, WIDTH, HIGHT);
        }

        /// <summary>
        /// Реализация метода по стиранию стеный с экрана
        /// </summary>
        /// <param name="clrColor">Цвет канвы игрового поля</param>
        public override void ClearDraw(Color clrColor)
        {
            gameField.graphics.FillRectangle(new SolidBrush(clrColor), x0, y0, WIDTH, HIGHT);
        }
    }
}
