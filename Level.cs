using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___DOOM_Game
{
    public abstract class GameLevel
    {
        public abstract void ShowCurrentLevel();
    }

    public class E1M1 : GameLevel 
    {
        public override void ShowCurrentLevel()
        {
            Console.WriteLine("Knee-Deep in the Dead: Level E1M1");
        }
    }

    public class Mars : GameLevel
    {
        public override void ShowCurrentLevel() 
        {
            Console.WriteLine("Awakening of the DOOM Slayer: Level Mars");
        }
    }
    public abstract class LevelFactory
    {
        public abstract GameLevel CreateLevel();
    }

    class E1M1Factory : LevelFactory
    {
        public override GameLevel CreateLevel()
        {
            return new E1M1();
        }
    }

    class MarsFactory : LevelFactory
    {
        public override GameLevel CreateLevel()
        {
            return new Mars();
        }
    }
}
