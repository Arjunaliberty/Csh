using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksClass
{
    public class TanksDecorationArmorUp : TanksDecoration
    {
        public TanksDecorationArmorUp(Tanks tank) : base(tank) {}

        public override void TankBonus()
        {
            tank.armor += 5;
        }
    }
}
