namespace Racketeer.Code.Core.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
    
public sealed class Camera
{
    
    public const float MinZ = 1f;
    public const float MaxZ = 2048f;

    private Vector2 position;
    private float z;
    private float baseZ;

    private float aspectRatio;
    private float fieldOfView;

    private Matrix view;
    private Matrix projection;

    //public Camera(Screen screen)
    //{
    //    
    //}
    
}