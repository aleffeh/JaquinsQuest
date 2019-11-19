using JaquinAdventures.Abstractions;
using JaquinAdventures.Entities;
using Otter;

namespace JaquinAdventures.Scenes
{
    public class MainScene : Scene
    {
        public ButtonComponent ButtonComponent { get; set; }
        public MainScene(Player player,Entities.Button buttonBase)
        {
            Add(player);
            Add(buttonBase);
        }

        public override void Start()
        {
            Add(ButtonComponent);
        }
    }
}