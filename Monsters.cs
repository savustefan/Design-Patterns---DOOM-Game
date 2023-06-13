using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns___DOOM_Game;

namespace Design_Patterns___DOOM_Game
{
       abstract class MonsterFactory
        {
            public abstract RangedMonster CreateRangedMonster();
            public abstract MeleeMonster CreateMeleeMonster();
        }

        class HellFactory : MonsterFactory
        {
            public override MeleeMonster CreateMeleeMonster()
            {
                return new Demon();
            }

        public override RangedMonster CreateRangedMonster()
            {
                return new Imp();
            }

        }

        class CyberFactory : MonsterFactory
        {
            public override MeleeMonster CreateMeleeMonster()
            {
                return new BaronOfHell();
            }

        public override RangedMonster CreateRangedMonster()
            {
                return new Cyberdemon();
            }
        
        }

        abstract class MeleeMonster
            {
            public abstract void Attack();
             }
        abstract class RangedMonster
            {
                public abstract void Attack();
            }

     
        class Imp : RangedMonster
        {
            public override void Attack()
            {
                Console.WriteLine("Imp");
            }
        }

        class Cyberdemon : RangedMonster
        {
            public override void Attack()
            {
                Console.WriteLine("Cyberdemon");
            }
        }

        class Demon : MeleeMonster
        {
            public override void Attack()
            {
                Console.WriteLine("Demon");
            }
        }

        class BaronOfHell : MeleeMonster
        {
            public override void Attack()
            {
                Console.WriteLine("Baron of Hell");
            }
        }
}

