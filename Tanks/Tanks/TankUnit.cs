using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksClass
{
    public class TankUnit : Tank
    {
        public TankUnit(int x, int y, int armor, int speed, TankDirect tankDirect, Color color, Graphics graphics) : base(x, y, armor, speed, tankDirect, color, graphics)
        {

        }

        // Реализуем абстрактные методы в abstract class Tnak
               
        public override void DecreaseBonusArmor()
        {
           
        }

        public override void DecreaseBonusPower()
        {
           
        }

        public override void DecreaseBonusSpeed()
        {
           
        }

        public override void IncreaseBonusArmor()
        {
            
        }

        public override void IncreaseBonusPower()
        {
            
        }

        public override void IncreaseBonusSpeed()
        {
            
        }
    }
}
