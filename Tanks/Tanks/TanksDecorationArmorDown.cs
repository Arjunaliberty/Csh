using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksClass
{
    public class TanksDecorationArmorDown : TanksDecoration
    {
        public TanksDecorationArmorDown(Tanks tank) : base(tank) { }

        public override void TankBonus()
        {
            if (tank.armor > 5)
            {
                tank.armor -= 5;
            }
        }
    }
   
}
