using JaquinAdventures.Entities;
using Otter;

namespace JaquinAdventures.Scenes
{
    public class MainScene : Scene
    {

        public MainScene(Player player,Entities.Button buttonBase)
        {
            Add(player);
            Add(buttonBase);
        }
    }
}