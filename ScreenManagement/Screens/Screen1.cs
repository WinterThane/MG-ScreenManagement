using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ScreenManagement.ScreenManagr;

namespace ScreenManagement.Screens
{
    public class Screen1 : Screen
    {
        private GraphicsDevice _graphicsDevice;

        public Screen1(GraphicsDevice device) : base(device, "screen1")
        {
            _graphicsDevice = device;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            _graphicsDevice.Clear(Color.White);
            base.Draw(gameTime);
        }
    }
}
