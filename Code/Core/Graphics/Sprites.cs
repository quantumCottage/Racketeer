namespace Racketeer.Code.Core.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public sealed class Sprites
{
    
    private SpriteBatch sprites;
    private Game game;
    
    public Sprites(Game game)
    {

        this.game = game;
        sprites = new SpriteBatch(game.GraphicsDevice);

    }

    public void Begin()
    {
        sprites.Begin();
    }

    public void End()
    {
        sprites.End();
    }

    public void Draw(Texture2D texture, Vector2 origin, Vector2 position, Color color)
    {
        
    }
    
}