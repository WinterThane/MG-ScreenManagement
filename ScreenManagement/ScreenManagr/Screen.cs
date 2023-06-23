using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ScreenManagement.ScreenManagr
{
    public class Screen
    {
        protected GraphicsDevice _device;
        public string Name { get; set; }

        public Screen(GraphicsDevice device, string name)
        {
            Name = name;
            _device = device;
        }

        public virtual bool Init()
        {
            return true;
        }

        public virtual void ShutDown() 
        { 
        }

        public virtual void Update(GameTime gameTime)
        {

        }

        public virtual void Draw(GameTime gameTime)
        {

        }
    }
}
