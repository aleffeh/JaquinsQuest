using JaquinAdventures.Interfaces;
using JaquinAdventures.Scenes;
using Otter;

namespace JaquinAdventures
{
    public class GameManager : IApplication 
    {
        private Game _game;

        public GameManager(Game game, MainScene mainScene)
        {
            game.FirstScene = mainScene;
            _game = game;
        }


        public void Run()
        {
            _game.Start();
        }
    }
}