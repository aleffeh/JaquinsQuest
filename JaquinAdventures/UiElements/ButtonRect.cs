using Otter;

namespace JaquinAdventures.UiElements
{
    public class ButtonRect : Entity
    {
        private Image Sprite;

        public ButtonRect(Vector2 size, Vector2 position, Color color)
        {
            Sprite = Image.CreateRectangle((int) size.X, (int) size.Y, color);
            Sprite.CenterOrigin();

            AddGraphic(Sprite);
        }

        public override void Update()
        {
            if (Input.MouseScreenX > X - Sprite.HalfWidth && Input.MouseScreenX < X + Sprite.HalfWidth &&
                Input.MouseScreenY > Y - Sprite.HalfHeight && Input.MouseScreenY < X + Sprite.HalfHeight)
                Sprite.Color = Color.Yellow;
            else
                Sprite.Color = Color.White;
        }
    }
}