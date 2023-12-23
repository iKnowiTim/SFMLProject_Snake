using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Snake.Models
{
    public class WindowManager
    {
        public WindowManager(string gameName, uint width = 800, uint height = 600)
        {
            window = new RenderWindow(new VideoMode(width, height), gameName);
        }

        public RenderWindow window;

        private void SetVerticalWindow(bool isVertical) => window.SetVerticalSyncEnabled(isVertical);
        public void Loop()
        {
            SetVerticalWindow(true);
            InitEvents();
            while (window.IsOpen)
            {
                window.DispatchEvents();
                window.Clear(Color.Black);
                window.Display();
            }
        }
        private void InitEvents()
        {
            window.Closed += WindowClosed;
            window.Resized += WindowResized;
        }
        private void WindowResized(object? sender, SizeEventArgs e) => window.SetView(new View(new FloatRect(0, 0, e.Width, e.Height)));

        private void WindowClosed(object? sender, EventArgs e) => window.Close();
    }
}
