using Microsoft.Xna.Framework.Graphics;

namespace Bliss.Models
{
  public class Animation
  {
    public int CurrentFrame { get; set; }
    public int FrameCount { get; set; }
    public int FrameHeight => Texture.Height;
    public float FrameSpeed { get; set; }
    public int FrameWidth => Texture.Width / FrameCount;
    public bool IsLooping { get; set; }
    public Texture2D Texture { get; private set; }

    public Animation(Texture2D texture, int frameCount)
    {
      Texture = texture;
      FrameCount = frameCount;
      IsLooping = true;
      FrameSpeed = 0.2f;
    }
  }
}