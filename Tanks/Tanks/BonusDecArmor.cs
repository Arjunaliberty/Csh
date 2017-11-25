using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TanksClass
{
    public class BonusDecArmor : TankDecoration
    {

        const int BONUS = 2;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="tank">Объект типа Tank</param>
        public BonusDecArmor(Tank tank) : base(tank)
        {

        }

        public override void Bonus()
        {
            if (this.armor > BONUS)
            {
                this.armor -= BONUS;
            }
        }
    }
}
