using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
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
            if (Keyboard.GetState().IsKeyDown(Keys.D)) 
            {
                ScreenManager.GoToScreen("screen2");
            }

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            _graphicsDevice.Clear(Color.White);
            base.Draw(gameTime);
        }
    }
}
