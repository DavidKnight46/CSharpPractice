using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpPracticeAppTwo.Weapons;

namespace CSharpPracticeAppTwo.Characters
{
    public class Polaris : CharacterClass
    {
        public Polaris(BaseWeapon weapon, Accessories.Accessory aces, int hp, float def) 
            : base("Polaris Wong", weapon, aces, hp, def)
        {
            
        }

        public string getName()
        {
            return this.name;
        }

         Status getStatus() {
            return this.status;
        }
    }
    
}
