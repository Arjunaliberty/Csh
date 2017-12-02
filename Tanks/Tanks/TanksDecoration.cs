using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksClass
{
    public abstract class TanksDecoration : Tanks
    {
        protected Tanks tank;

        public TanksDecoration(Tanks tank) : base(tank.x0, tank.y0, tank.speed, tank.power, tank.armor, tank.color, tank.gameField)
        {
            this.tank = tank;
        }
    }
}
