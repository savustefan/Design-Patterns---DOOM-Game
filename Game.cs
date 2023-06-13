using System;
using Design_Patterns___DOOM_Game;


    class DoomGame
    {
        private RangedMonster _rangedMonster;
        private MeleeMonster _meleeMonster;
        private Weapon _weapon;
        private GameLevel _gameLevel;

        public DoomGame(MonsterFactory factory, Weapon weapon, GameLevel gameLevel)
        {
            _rangedMonster = factory.CreateRangedMonster();
            _meleeMonster = factory.CreateMeleeMonster();
            _weapon = weapon;
            _gameLevel = gameLevel;
    }


    public void Play()
    {
        

            Scoreboard scoreboard = Scoreboard.Instance;
            scoreboard.AddScore(10);
            int currentScore = scoreboard.GetScore();
            _gameLevel.ShowCurrentLevel();
            Console.WriteLine("Doom Guy Rip & Tears " + _rangedMonster.GetType().Name);
            Console.WriteLine("Doom guy Rip & Tears " + _meleeMonster.GetType().Name);
            Console.WriteLine("Current Score: " + currentScore);
            _weapon.Use();
            
        }
    }

    class MainApp
    {
        static void Main()
        {
            MonsterFactory factory = new HellFactory();
            Weapon weapon = new Chainsaw();
            GameLevel gameLevel = new E1M1();
            DoomGame doomGame = new DoomGame(factory, weapon, gameLevel);
            doomGame.Play();

            factory = new CyberFactory();
            weapon = new BFG9000();
            gameLevel = new Mars();
            doomGame = new DoomGame(factory, weapon, gameLevel);
            doomGame.Play();

            Console.ReadKey();
        }
    }


