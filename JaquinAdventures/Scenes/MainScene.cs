using JaquinAdventures.Entities;
using Otter;

namespace JaquinAdventures.Scenes
{
    public class MainScene : Scene
    {

        public MainScene(Player player)
        {
            Add(player);
        }
    }
}