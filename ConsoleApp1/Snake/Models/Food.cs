using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Snake.Models
{
    public class Food
    {
        public Food ()
        {
            point = new Point(0, 0);
        }
        public Point point;
        public int Amount { get; set; }
    }
}
