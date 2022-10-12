using System.Collections.Generic;
namespace Racketeer;

public class Entity
{

    public string Name;
    
    private StateMachine myStateMachine;
    private List<Component> myComponents;

    Entity(string EntityName, StateMachine EntityStateMachine, ref List<Component> EntityComponents)
    {
        Name = EntityName;

        myStateMachine = EntityStateMachine;
        myComponents = EntityComponents;
    }
    
    public void Update()
    {
        myStateMachine.Update();
    }

    public void Draw()
    {
        myStateMachine.Draw();
    }
    
}