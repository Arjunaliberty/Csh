using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksClass
{
    public class Bonus : Figures
    {
        const int WIDTH = 5;
        const int HIGHT = 5;

        public int x0 { get; private set; }
        public int y0 { get; private set; }
        public int ttl { get; set; }
        Color color;
        GameField gameField;

        public Bonus(int x0, int y0, int ttl, Color color, GameField gameField)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.ttl = ttl;
            this.color = color;
            this.gameField = gameField;
        }

        public override void ShowDraw()
        {
            gameField.graphics.FillRectangle(new SolidBrush(color), x0, y0, WIDTH, HIGHT);
        }

        public override void ClearDraw(Color clrColor)
        {
            gameField.graphics.FillRectangle(new SolidBrush(clrColor), x0, y0, WIDTH, HIGHT);
        }

    }
}
