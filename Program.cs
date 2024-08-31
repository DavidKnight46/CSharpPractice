using CSharpPracticeAppTwo.Characters;
using CSharpPracticeAppTwo.Weapons;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeAppTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Polaris polaris = new Polaris(new GunBlade(), new Accessories.None(), 100, 5f);
            
            
            Guard guard = new Guard("Bob", 50, 0.96f);
            Guard guard1 = new Guard("Rob", 50, 0.96f);
            Guard guard2 = new Guard("Gob", 50, 0.96f);

            List<CharacterClass> guards = new List<CharacterClass>() { 
                guard, guard1, guard2
            };


            Console.WriteLine("Welcome " + polaris.getName() + " welcome to the arena.\n");
            Console.WriteLine("\n");
            Console.WriteLine("Welcome " + guard.getName() + " welcome to the arena.");

            Console.WriteLine("Please select accessory: [1] Life Saver Bangle [2] Dragon Bangle [3] Stone Bangle");
            string selected = Console.ReadLine();

            if (selected.Equals("1"))
            {
                polaris.setTheAccessory(new Accessories.LifeSaverBangle());
            }
            else {
                polaris.setTheAccessory(new Accessories.LifeSaverBangle());
            }

            Console.WriteLine(polaris);

            do {

                Random rand = new Random();
                var r = rand.Next(guards.Count());

                Console.WriteLine("Polaris attack!!! Type [A]"); 
                var action = Console.ReadLine();

                if (action == "A") {

                    Random random = new Random();
                    int b = random.Next(2);

                    if (b == 0)
                    {
                        guards[r].Defend();
                        Console.WriteLine("Guard successfully defend!!!");
                    }

                    polaris.Attack(guards[r], guards);
                }


            } while (isAllGuardsDefeated(guards));

            Console.WriteLine("Guards defeated! Polaris wins! Press Enter to close virtual training sim");

            Console.ReadLine();
        }

        public static Boolean isAllGuardsDefeated(List<CharacterClass> list) {
            Boolean isAllGuardsDefeated = false;
            
            for (int i = 0; i < list.Count(); i++) {
                if (list[i].status == Status.ALIVE) { 
                    isAllGuardsDefeated = true; 
                    break;
                }
            }

            return isAllGuardsDefeated;
        }
    }
}
