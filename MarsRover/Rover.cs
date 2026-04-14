using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover  //position and direction. And movement logic.
{
    public class Rover
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

        public void ExecuteCommands(List<Command> commands, Plateau plateau)
        {
            foreach (var command in commands)
            {
                switch (command)
                {
                    case Command.L:
                        TurnLeft();
                        break;

                    case Command.R:
                        TurnRight();
                        break;

                    case Command.M:
                        Move(plateau);
                        break;
                }
            }
        }

        private void TurnLeft()
        {
            Direction = Direction switch
            {
                Direction.N => Direction.W,
                Direction.W => Direction.S,
                Direction.S => Direction.E,
                Direction.E => Direction.N,
                _ => Direction
            };
        }

        private void TurnRight()
        {
            Direction = Direction switch
            {
                Direction.N => Direction.E,
                Direction.E => Direction.S,
                Direction.S => Direction.W,
                Direction.W => Direction.N,
                _ => Direction
            };
        }

        private void Move(Plateau plateau)
        {
            int newX = X;
            int newY = Y;

            switch (Direction)
            {
                case Direction.N:
                    newY++;
                    break;
                case Direction.E:
                    newX++;
                    break;
                case Direction.S:
                    newY--;
                    break;
                case Direction.W:
                    newX--;
                    break;
            }

            if (plateau.IsWithinBounds(newX, newY))
            {
                X = newX;
                Y = newY;
            }
        }




    }
}
