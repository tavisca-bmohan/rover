using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover
{
    public class RoverActionsOnCommand
    {
        public MapVectorOnSurface TurnLeft(MapVectorOnSurface Map)
        {
            switch (Map.Current_Direction)
            {
                case Direction.East : Map.Current_Direction = Direction.North; break;
                case Direction.North: Map.Current_Direction = Direction.West; break;
                case Direction.West : Map.Current_Direction = Direction.South; break;
                case Direction.South: Map.Current_Direction = Direction.East; break;
                default : Map.Current_Direction = Direction.Wrong_Direction; break;
            }
            return Map;
        }

        public MapVectorOnSurface TurnRight(MapVectorOnSurface Map)
        {
            switch (Map.Current_Direction)
            {
                case Direction.East : Map.Current_Direction = Direction.South; break;
                case Direction.South: Map.Current_Direction = Direction.West; break;
                case Direction.West : Map.Current_Direction = Direction.North; break;
                case Direction.North: Map.Current_Direction = Direction.East; break;
                default: Map.Current_Direction = Direction.Wrong_Direction; break;
            }
            return Map;
        }

        public MapVectorOnSurface MoveForward(MapVectorOnSurface Map)
        {
            switch (Map.Current_Direction)
            {
                case Direction.East : Map.X_Coordinate++; break;
                case Direction.North: Map.Y_Coordinate++; break;
                case Direction.West : Map.X_Coordinate--; break;
                case Direction.South: Map.Y_Coordinate--; break;
                default : Map.Current_Direction = Direction.Wrong_Direction; break;
            }
            return Map;
        }
    }
}
