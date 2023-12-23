using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Snake.Models
{
    public class Point
    {
        public Point (float x, float y)
        {
            this.x = x; this.y = y;
        }

        private float x, y;

        public float getX { get { return x; } }
        public float getY { get { return y; } }
    }
}
