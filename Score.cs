using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns___DOOM_Game;


public class Scoreboard
{
    private static Scoreboard _instance;
    private int _score;

    private Scoreboard()
    {
        _score = 0;
    }

    public static Scoreboard Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Scoreboard();
            return _instance;
        }
    }

    public int GetScore()
    {
        return _score;
    }

    public void AddScore(int points)
    {
        _score += points;
    }

    public void ResetScore()
    {
        _score = 0;
    }
}

