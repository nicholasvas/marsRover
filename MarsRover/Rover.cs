using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover  //position and direction. And movement logic.
{
    internal class Rover
    {

        public int X {  get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }

        public Rover(int x, int y, Direction direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }
    }
}
