namespace Racketeer;

public interface State
{
    void Enter();
    void Update();
    void Draw();
    void Exit();
}