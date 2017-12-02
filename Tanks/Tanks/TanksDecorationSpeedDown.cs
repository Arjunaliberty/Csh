using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksClass
{
    public class TanksDecorationSpeedDown : TanksDecoration
    {
        public TanksDecorationSpeedDown(Tanks tank) : base(tank) { }

        public override void TankBonus()
        {
            if(tank.speed > 5)
            {
                tank.speed -= 5;
            }
        }
    }
}
