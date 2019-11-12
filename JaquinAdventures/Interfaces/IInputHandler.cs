using Otter;

namespace JaquinAdventures.Interfaces
{
    public interface IInputHandler
    {
        Input Input { get; }
        Vector2 GetDirection();
        Vector2 GetDirection(float speed);
    }
}