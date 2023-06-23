using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace ScreenManagement.ScreenManagr
{
    public static class ScreenManager
    {
        private static readonly List<Screen> ScreensList = new();
        private static bool _started;
        private static Screen _previous;

        public static Screen ActiveScreen;

        public static void AddScreen(Screen screen)
        {
            foreach (Screen scr in ScreensList)
            {
                if (scr.Name == screen.Name)
                {
                    return;
                }
            }
            ScreensList.Add(screen);
        }

        public static int GetScreenNumber()
        {
            return ScreensList.Count;
        }

        public static Screen GetScreen(int index)
        {
            return ScreensList[index];
        }

        public static void GoToScreen(string screenName)
        {
            foreach(Screen screen in ScreensList)
            {
                if (screen.Name == screenName)
                {
                    _previous = ActiveScreen;
                    ActiveScreen?.ShutDown();

                    ActiveScreen = screen;
                    if (_started)
                    {
                        ActiveScreen.Init();
                    }
                    return;
                }
            }
        }

        public static void Init()
        {
            _started = true;
            ActiveScreen?.Init();
        }

        public static void GoBack()
        {
            if (_previous == null) return;
            GoToScreen(_previous.Name);
        }

        public static void Update(GameTime gameTime)
        {
            if (!_started) return;
            ActiveScreen?.Update(gameTime);
        }

        public static void Draw(GameTime gameTime)
        {
            if (!_started) return;
            ActiveScreen?.Draw(gameTime);
        }
    }
}
