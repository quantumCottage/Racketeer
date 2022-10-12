namespace Racketeer;

public class StateMachine
{

    private State currentState;
    private State nextState;
    private State previousState;

    public void Update()
    {
        if (currentState == null && nextState != null)
        {
            currentState = nextState;
            nextState = null;
            
            currentState.Enter();
            currentState.Update();
        }

        if (currentState != null && nextState != null)
        {
            currentState.Exit();
            
            previousState = currentState;
            currentState = nextState;
            nextState = null;
            
            currentState.Enter();
            currentState.Update();
        }
        
        if (currentState != null && nextState == null)
        {
            currentState.Update();
        }
 
    }

    public void Draw()
    {
        
        if (currentState != null)
        {
            currentState.Draw();
        }
        
    }
    
}