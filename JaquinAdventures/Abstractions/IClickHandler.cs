using System;
using JaquinAdventures.DataStructs;
using Otter;

namespace JaquinAdventures.Entities
{
    public interface IClickHandler : IDisposable
    {
        StateColors StateColors { get; set; }
        event Action<MouseButton> MouseClick;
        event Action OnHoverStartEvent;
        event Action OnHoverEndEvent;
        void OnClick(MouseButton buttonPressed);
        void OnHoverEnter();
        void OnHoverExit();
    }
}