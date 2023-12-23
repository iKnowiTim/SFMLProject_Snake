﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Snake.Models
{
    public class Snake
    {
        public Snake()
        {
            point = new Point(0, 0);
            snakeSize = 1;
            score = 0;
        }

        private Point point;
        private int snakeSize;
        private int score;
    }
}
