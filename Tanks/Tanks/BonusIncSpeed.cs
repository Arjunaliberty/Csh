using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksClass
{
    public class BonusIncSpeed : TankDecoration
    {
        const int BONUS = 2;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="tank"></param>
        public BonusIncSpeed(Tank tank) : base(tank)
        {
           
        }

        /// <summary>
        /// Переопределенный метод по увеличению скорости танка
        /// </summary>
        /// <returns></returns>
        public override void Bonus()
        {
            tank.speed += BONUS;   
        }
    }
}
