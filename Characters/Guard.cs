using CSharpPracticeAppTwo.Accessories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeAppTwo.Characters
{
    internal class Guard : CharacterClass
    {
        public Guard(string name, int hp, float def) 
            : base(name, new Weapons.Baton(), new None(), hp, def)
        {
        }

        public string getName()
        {
            return this.name;
        }

        public Status getStatus()
        {
            return this.status;
        }
    }
}
