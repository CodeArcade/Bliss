using Bliss.States;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Bliss.Manager
{
    public class StateManager
    {
        public static State CurrentState { get; private set; }
        private static State NextState { get; set; }
        private static string StateName { get; set; }
        private object[] Parameter { get; set; }

        //public void Draw(GameTime gameTime, SpriteBatch spriteBatch) => CurrentState
    }
}
