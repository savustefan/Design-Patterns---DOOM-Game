using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___DOOM_Game
{
    public abstract class Weapon
    {
        public abstract void Use();
    }

    public class Chainsaw : Weapon
    {
        public override void Use()
        {
            Console.WriteLine("Chainsaw found!");
        }
    }

    class BFG9000 : Weapon
    {
        public override void Use()
        {
            Console.WriteLine("BFG9000 found!");
        }
    }

    abstract class WeaponFactory
    {
        public abstract Weapon CreateWeapon();
    }

    class ChainsawFactory : WeaponFactory
    {
        public override Weapon CreateWeapon()
        {
            return new Chainsaw();
        }
    }

    class BFG9000Factory : WeaponFactory
    {
        public override Weapon CreateWeapon()
        {
            return new BFG9000();
        }
    }  
}
