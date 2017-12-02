using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksClass
{
    public class TanksDecorationPowerDown : TanksDecoration
    {
        public TanksDecorationPowerDown(Tanks tank) : base(tank){

        }

        public override void TankBonus()
        {
            if(tank.power > 5)
            {
                tank.power -= 5;
            }
        }
    }
}
