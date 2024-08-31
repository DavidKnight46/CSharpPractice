using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeAppTwo.Accessories
{
    public abstract class Accessory
    {
        protected float statBounse;
        protected AccessoryType type;
        protected string name { get; }

        public Accessory(string name,  float bounse, AccessoryType type) { 
            this.statBounse = bounse;
            this.type = type;
            this.name = name;
        }

        public float applyEffect(float statvalue)
        {
            return statvalue * this.statBounse;
        }

        public AccessoryType getAccessoryType() { return this.type; }

        public override string ToString() { 
            return this.name;
        }
    }
}
