using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksClass
{
    public class BonusIncArmor : TankDecoration
    {
        const int BONUS = 2;

        public BonusIncArmor(Tank tank) : base(tank)
        {

        }

        public override void Bonus()
        {
            tank.armor += BONUS;
        }
    }
}
