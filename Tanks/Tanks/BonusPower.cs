using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksClass
{
    public class BonusIncPower : TankDecoration
    {
        const int BONUS = 2;

        public BonusIncPower(Tank tank) : base(tank)
        {

        }

        public override void Bonus()
        {
            tank.power += BONUS;
        }
    }
}
