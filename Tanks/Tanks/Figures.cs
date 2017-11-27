using System;
using System.Drawing;

namespace TanksClass
{
    public abstract class Figures
    {
        public Figures() { }

        /// <summary>
        /// Метод по отрисовки фигур на экране
        /// </summary>
        public abstract void ShowDraw();

        /// <summary>
        /// Метод по стиранию фигур с экрана
        /// </summary>
        public abstract void ClearDraw(Color clrColor);
    }
}
