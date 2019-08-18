using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover
{
    public class RoverPosition
    {
        public MapVectorOnSurface Map = new MapVectorOnSurface();
        public RoverPosition()
        {
            Map.X_Coordinate = 0;
            Map.Y_Coordinate = 0;
            Map.Current_Direction = Direction.North;
        }

        public RoverPosition(int x_Coordinate, int y_Coordinate, char Direction)
        {
            Map.X_Coordinate = x_Coordinate;
            Map.Y_Coordinate = y_Coordinate;
            Map.Current_Direction = GetCurrentDirection(Direction);
        }

        public Direction GetCurrentDirection(char direction)
        {
            switch (direction)
            {
                case 'E': return Direction.East;
                case 'W': return Direction.West;
                case 'N': return Direction.North;
                case 'S': return Direction.South;
            }
            return Direction.Wrong_Direction;
        }

    }
}
