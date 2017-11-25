using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksClass
{
    class BonusDecPower : TankDecoration
    {
        const int BONUS = 2;

        public BonusDecPower(Tank tank) : base(tank)
        {

        }

        public override void Bonus()
        {
            if (tank.power > BONUS)
            {
                tank.power -= BONUS;
            }
        }
    }
}
