using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeAppTwo.Weapons
{
    public class BaseWeapon
    {
        protected string name { get; }
        public int damage { get; }

        public BaseWeapon(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
