using System;
namespace Assets.Scripts.Entities
{
    public class Game
    {
        public string PlayerName { get; set; }
        public Level CurrentLevel { get; set; }
        private static Game _instance;
        public Game Instance()
        {
            if (_instance == null)
            {
                _instance = new Game();
                _instance.CurrentLevel = new Level();
                //_instance.CurrentLevel.characters;
            }
            return _instance;
        }
    }
}
