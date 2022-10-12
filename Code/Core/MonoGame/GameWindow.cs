using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Racketeer;

public class GameWindow : Game
{

    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    private List<Entity> entityList = new List<Entity>();

    public GameWindow()
    {
        
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;

    }

    protected override void Initialize()
    {
        
        // game initialization
        
        Debug.Print("Go away warning");
        base.Initialize();
        
    }

    protected override void LoadContent()
    {
        
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here

    }

    protected override void Update(GameTime gameTime)
    {

        foreach (Entity e in entityList)
        {
            e.Update();
        }

        base.Update(gameTime);
        
    }

    protected override void Draw(GameTime gameTime)
    {
        
        GraphicsDevice.Clear(Color.DarkGreen);

         _spriteBatch.Begin();
         
         foreach (Entity e in entityList)
         {
             e.Draw();
         }
         
         _spriteBatch.End();
        
        base.Draw(gameTime);
        
    }
}