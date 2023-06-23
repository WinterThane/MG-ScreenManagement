using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ScreenManagement.ScreenManagr;

namespace ScreenManagement.Screens
{
    public class Screen2 : Screen
    {
        private GraphicsDevice _graphicsDevice;

        public Screen2(GraphicsDevice device) : base(device, "screen2")
        {
            _graphicsDevice = device;
        }

        public override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.A)) 
            {
                ScreenManager.GoToScreen("screen1");
            }

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            _graphicsDevice.Clear(Color.Black);
            base.Draw(gameTime);
        }
    }
}
