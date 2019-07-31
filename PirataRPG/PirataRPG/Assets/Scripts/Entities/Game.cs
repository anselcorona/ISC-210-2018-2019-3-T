using System;
public class Game
{

    public string PlayerName { get; set; }
    public Level CurrentLevel { get; set; }
    private static Game _instance;



    public Game Instance()
    {
        if(_instance == null)
        {
            _instance = new Game();
        }
        return _instance;
    }
}
