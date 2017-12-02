using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksClass
{
    public class TanksDecorationSpeedUp : TanksDecoration
    {
        public TanksDecorationSpeedUp(Tanks tank) : base(tank) {}

        public override void TankBonus()
        {
            tank.speed += 5;
        }
    }
}
