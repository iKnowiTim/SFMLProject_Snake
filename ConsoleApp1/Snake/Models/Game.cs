using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1.Snake.Models
{
    public class Game
    {
        public Game()
        {
            windowManager = new WindowManager("Snake");
        }

        public WindowManager windowManager;

        public void Start()
        {
            windowManager.Loop();
        }

        public void Stop()
        {

        }

        public void Update()
        {

        }
    }
}
