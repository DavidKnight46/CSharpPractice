using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeAppTwo.Accessories
{
    public class LifeSaverBangle : Accessory
    {
        public LifeSaverBangle(): base("Life Saver Bangle", 1.05f, AccessoryType.HP) { 
        
        
        }

        /*public float getBounse(float hp) { 
            return hp*this.statBounse;
        }*/
    }
}
