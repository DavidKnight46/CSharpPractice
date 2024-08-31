using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using CSharpPracticeAppTwo.Accessories;
using CSharpPracticeAppTwo.Weapons;

namespace CSharpPracticeAppTwo.Characters
{
    public abstract class CharacterClass : Actions
    {
        protected string name { get; }
        protected BaseWeapon weapon { get; set; }
        protected float startingHp { get; set; }
        protected float baseDefence { get; set; }
        protected float baseATK { get; set; }
        public Status status { get; set; }
        protected Accessory accessory { get; set; }
        private int baseDamage { get; set; }
        public CharacterClass(string name, BaseWeapon weapon, Accessory accessory, float initialHp, float baseDefence) {
            this.name = name;
            this.weapon = weapon;
            this.startingHp = initialHp;
            this.baseDefence = baseDefence;
            this.status = Status.ALIVE;
            this.baseATK = 1.005f;
            this.accessory = accessory;

            this.baseDamage = weapon.damage;
        }

        public void setTheAccessory(Accessory accessory)
        {
            this.accessory = accessory;

            applyAccessoryEffect();
        }

        private void applyAccessoryEffect()
        {
            switch(this.accessory.getAccessoryType())
            {
                case AccessoryType.HP: 
                    this.startingHp = this.accessory.applyEffect(startingHp);
                    break;
                case AccessoryType.DEF:
                    this.baseDefence = this.accessory.applyEffect(baseDefence);
                    break;
                case AccessoryType.ATK:
                    this.baseATK = this.accessory.applyEffect(baseATK);
                    break;
            }
        
        }

        public void Defend() { 
            this.baseDamage = weapon.damage / 2;
        }

        public void Attack(CharacterClass target, List<CharacterClass> characterList)
        {
            target.takeDamage(this.baseDamage, characterList);
        }

        public void takeDamage(int damage, List<CharacterClass> characterList)
        {
            if (startingHp-damage <= 0) { 
                Console.WriteLine($"{name} has died!");
                this.status = Status.DEAD;

                characterList.Remove(this);

                Console.WriteLine(characterList.Count() + " remaining");
            }
            else
            {
                startingHp -= (damage*baseATK)*baseDefence;

                Console.WriteLine("Guard " + this.name + " has current HP: " + Math.Round(startingHp, 0));
            }
        }

        public override string ToString() { return $"{name}.\n Weapon: {weapon}. Accessory: {accessory}."; }
    }
}
