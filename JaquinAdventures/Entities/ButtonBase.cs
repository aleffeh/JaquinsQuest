using System;
using Otter;

namespace JaquinAdventures.Entities
{
    public abstract class ButtonBase : Entity
    {
        private Input input;
        private Game game;
        protected Image Sprite;
        protected event Action OnClickEvent = delegate { };
        protected Color ButtonColor = Color.Random, HoveredColor = Color.Random, ClickedColor = Color.Random;
        private bool isPressed;
        private bool isPressedLastFrame;
        private bool isHovering;

        public ButtonBase(Game game, Input input)
        {
            this.game = game;
            this.input = input;
            // Sprite = Image.CreateRectangle(300, 100);
            //Sprite.CenterOrigin();
            Layer = -10;
            OnClickEvent += OnCLick;
        }

        protected virtual void OnCLick()
        {
        }

        public override void Update()
        {
            UpdateState();

            if (isPressed)
            {
                Sprite.Color = ClickedColor;
                if (!isPressedLastFrame)
                    OnClickEvent?.Invoke();
            }
            else if (isHovering)
                Sprite.Color = HoveredColor;
            else
                Sprite.Color = ButtonColor;
        }

        private void UpdateState()
        {
            isPressedLastFrame = isPressed;

            if (input.MouseScreenX > X - Sprite.HalfWidth && input.MouseScreenX < X + Sprite.HalfWidth &&
                input.MouseScreenY > Y - Sprite.HalfHeight && input.MouseScreenY < Y + Sprite.HalfHeight)
            {
                isHovering = true;
                isPressed = input.MouseButtonDown(MouseButton.Left);
            }
            else
                isHovering = false;
        }

        public override void Render()
        {
            Sprite.Render(X, Y);
        }
    }
}