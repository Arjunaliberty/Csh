using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksClass
{
    public class Tank1 : Tanks
    {

        public Tank1(int x0, int y0, int speed, int power, int armor, Color color, GameField gameField) : 
               base(x0, y0, speed, power, armor, color, gameField)
        {

        }

        public override void TankBonus() {}

    }
}
