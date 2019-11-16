using System;
using Otter;

namespace JaquinAdventures.Entities
{
    public abstract class ButtonBase : Entity, IDisposable
    {
        private new readonly Input _input;
        private Game _game;
        
        protected Image Sprite;
        protected event Action OnClickEvent = delegate { };
        protected event Action OnHoverStartEvent = delegate { };
        protected event Action OnHoverEndEvent = delegate { };
        
        protected readonly Color ButtonColor = Color.Random;
        protected readonly Color HoveredColor = Color.Random;
        protected readonly Color ClickedColor = Color.Random;
        
        private MouseButton _button;
        private bool _isPressed;
        private bool _isPressedLastFrame;
        private bool _isHovered;

        protected ButtonBase(Game game, Input input,MouseButton button)
        {
            _game = game;
            _input = input;
            _button = button;
            Layer = -10;

            OnClickEvent += OnCLick;
            OnHoverStartEvent += OnHoverEnter;
            OnHoverEndEvent += OnHoverExit;
        }

        protected virtual void OnCLick()
        {
        }

        protected virtual void OnHoverEnter()
        {
        }

        protected virtual void OnHoverExit()
        {
        }

        public override void Update()
        {
            UpdateState();

            if (_isPressed)
            {
                Sprite.Color = ClickedColor;
                if (!_isPressedLastFrame)
                    OnClickEvent?.Invoke();
            }
            else if (_isHovered)
                Sprite.Color = HoveredColor;
            else
                Sprite.Color = ButtonColor;
        }

        public override void UpdateFirst() => _isPressedLastFrame = _isPressed;

        private void UpdateState()
        {
            if (_input.MouseScreenX > X - Sprite.HalfWidth && _input.MouseScreenX < X + Sprite.HalfWidth &&
                _input.MouseScreenY > Y - Sprite.HalfHeight && _input.MouseScreenY < Y + Sprite.HalfHeight)
            {
                if (!_isHovered)
                    OnHoverStartEvent?.Invoke();
                _isHovered = true;
                _isPressed = _input.MouseButtonDown(_button);
            }
            else
            {
                if(_isHovered)
                    OnHoverEndEvent?.Invoke();
                _isHovered = false;
            }
        }

        public override void Render() => Sprite.Render(X, Y);

        public void Dispose()
        {
            OnClickEvent -= OnCLick;
            OnHoverStartEvent -= OnHoverEnter;
            OnHoverEndEvent -= OnHoverExit;
        }
    }
}