using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksClass
{
    public class TanksDecorationPowerUp : TanksDecoration
    {
        public TanksDecorationPowerUp(Tanks tank) : base(tank)
        {

        }

        /// <summary>
        /// Реализация абстрактного метода класса Tanks
        /// </summary>
        public override void TankBonus()
        {
            tank.power += 5;
        }
    }
}
