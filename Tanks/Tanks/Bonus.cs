using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum BonusType
{
    IncreaseBonusSpeed,
    IncreaseBonusArmor,
    IncreaseBonusPower,
    DecreaseBonusSpeed,
    DecreaseBonusArmor,
    DecreaseBonusPower
}

namespace TanksClass
{
    public class Bonus
    {
        /// <summary>
        /// Ширина бонуса
        /// </summary>
        const int BONUS_WIDTH = 10;
        /// <summary>
        /// Высота бонуса
        /// </summary>
        const int BONUS_HIGHT = 10;
        /// <summary>
        /// Верхняя левая координата по оси x
        /// </summary>
        public int x0 { get; private set; }
        /// <summary>
        /// Верхняя левая координата по оси y
        /// </summary>
        public int y0 { get; private set; }
        /// <summary>
        /// Время жизния бонуса time to life
        /// </summary>
        public int ttl { get; set; }

        /// <summary>
        /// переменная для хранения типа бонуса
        /// </summary>
        public BonusType bonusType { get; private set; }

        Color color { get; set; }
        Graphics graphics = null;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="x0">координата x</param>
        /// <param name="y0">координата y</param>
        /// <param name="ttl">время жизни бонуса</param>
        /// <param name="bonusType">тип бонуса</param>
        /// <param name="color">цвет бонуса</param>
        /// <param name="graphics">канва</param>
        public Bonus(int x0, int y0, int ttl, BonusType bonusType, Color color, Graphics graphics)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.ttl = ttl;
            this.bonusType = bonusType;
            this.color = color;
            this.graphics = graphics;
        }

        /// <summary>
        /// Метод по отрисовке бонусов
        /// </summary>
        public void ShowBonus()
        {
            graphics.FillRectangle(new SolidBrush(color), x0, y0, BONUS_WIDTH, BONUS_HIGHT);
        }

        /// <summary>
        /// Метод по стиранию бонусов
        /// </summary>
        /// <param name="clrColor">Color clrColor</param>
        public void ClearBonus(Color clrColor)
        {
            graphics.FillRectangle(new SolidBrush(clrColor), x0, y0, BONUS_WIDTH, BONUS_HIGHT);
        }
    }
}
