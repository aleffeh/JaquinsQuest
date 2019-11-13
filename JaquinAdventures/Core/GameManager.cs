using JaquinAdventures.Interfaces;
using JaquinAdventures.Scenes;
using Otter;

namespace JaquinAdventures
{
    public class GameManager : IApplication 
    {
        private Game game;

        public GameManager(Game game, MainScene mainScene)
        {
            game.FirstScene = mainScene;
            this.game = game;
        }


        public void Run()
        {
            game.Start();
        }
    }
}