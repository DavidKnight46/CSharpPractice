using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeAppTwo.Characters
{
    internal interface Actions
    {
        void Attack(CharacterClass target, List<CharacterClass> characterList);

        void takeDamage(int damage, List<CharacterClass> characterList);

        void Defend();
    }
}
