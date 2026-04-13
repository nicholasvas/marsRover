using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover  //size of "grid" and move limits
{
    public class Plateau
    {
        public int LimitX { get; set; }
        public int LimitY { get; set; }

        public Plateau(int limitX, int limitY)
        {
            LimitX = limitX;
            LimitY = limitY;
        }

        public bool IsWithinBounds(int x, int y)
        {
            return x >= 0 && x <= LimitX && y >= 0 && y <= LimitY;  //not sure if this works yet
        }
    }
}
