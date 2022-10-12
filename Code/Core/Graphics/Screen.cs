namespace Racketeer.Code.Core.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Racketeer.Code.Utility;

public sealed class Screen
{

    private const int MinDim = 64;
    private const int MaxDim = 4096;
    
    private Game game;
    private RenderTarget2D target;

    public int Width
    {
        get { return target.Width; }
    }

    public int Height
    {
        get { return target.Height; }
    }
    
    public Screen(Game game, int width, int height)
    {
        width = Toolbox.Clamp(width, Screen.MinDim, Screen.MaxDim);
        height = Toolbox.Clamp(height, Screen.MinDim, Screen.MaxDim);

        target = new RenderTarget2D(game.GraphicsDevice, width, height);
    }

    public void Set()
    {
        game.GraphicsDevice.SetRenderTarget(target);
    }

    public void UnSet()
    {
        game.GraphicsDevice.SetRenderTarget(null);
    }

    public void Present(SpriteBatch spriteBatch)
    {

        Rectangle destinationRectangle = CalculateDestinationRectangle();
        
        spriteBatch.Begin();
        spriteBatch.Draw(target, destinationRectangle, Color.White);
        spriteBatch.End();
    }

    private Rectangle CalculateDestinationRectangle()
    {

        return new Rectangle(0,0,10,10);
    }
    
}