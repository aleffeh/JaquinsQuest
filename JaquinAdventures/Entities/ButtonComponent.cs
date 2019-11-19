using JaquinAdventures.DataStructs;
using Otter;
using Color = System.Drawing.Color;

namespace JaquinAdventures.Entities
{
    public class ButtonComponent : Entity
    {
        public IClickHandler ClickHandler { get; set; }

        public ButtonComponent()
        {
            Graphic = Image.CreateRectangle(300, 200);
            Graphic.CenterOrigin();
            X = 900;
            Y = 200;
        }

        public override void Start()
        {
            ClickHandler.StateColors = new StateColors(
                Color.FromArgb(255, 129, 0),
                Color.FromArgb(255, 206, 0),
                Color.FromArgb(182, 159, 0));

            AddComponent((Component) ClickHandler);
        }
    }
}