using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksClass
{
    public abstract class TankDecoration : Tank
    {
        protected Tank tank;

        public TankDecoration(Tank tank) : base(tank.x0, tank.y0, tank.armor, tank.speed, tank.tankDirect, tank.color, tank.graphics)
        {
            this.tank = tank;
        }
    }
}
