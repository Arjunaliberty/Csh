using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksClass
{
    public class BonusDecSpeed : TankDecoration
    {

        const int BONUS = 2;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="tank"></param>
        public BonusDecSpeed(Tank tank) : base(tank)
        {

        }

        public override void Bonus()
        {
            if (tank.speed > BONUS)
            {
                tank.speed -= BONUS;
            }
        }
    }
}
