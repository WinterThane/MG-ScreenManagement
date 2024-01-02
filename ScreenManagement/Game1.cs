using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ScreenManagement.ScreenManagr;
using ScreenManagement.Screens;

namespace ScreenManagement
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            ScreenManager.AddScreen(new Screen1(GraphicsDevice));
            ScreenManager.AddScreen(new Screen2(GraphicsDevice));
            ScreenManager.GoToScreen("screen1");

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            ScreenManager.Init();
        }

        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }

            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                ScreenManager.GoToScreen("screen2");
            }

            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                ScreenManager.GoToScreen("screen1");
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Blue);

            ScreenManager.Draw(gameTime);

            base.Draw(gameTime);
        }
    }
}