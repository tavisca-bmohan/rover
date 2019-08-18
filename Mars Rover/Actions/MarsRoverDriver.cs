using System;
using Mars_Rover;

namespace Mars_Rover
{
    public class MarsRoverDriver
    {
        private RoverActionsOnCommand Action = new RoverActionsOnCommand();
        
        public MapVectorOnSurface FindRoverFinlPositionAndDirection(MapVectorOnSurface Map, string input)
        {
            RoverPosition Position = new RoverPosition(Map.X_Coordinate, Map.Y_Coordinate, (char)Map.Current_Direction);
            for(int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'L' : Action.TurnLeft(Position.Map); break;
                    case 'R' : Action.TurnRight(Position.Map); break;
                    case 'F' : Action.MoveForward(Position.Map); break; 
                }
            }
            return Position.Map;
        }
    }
}
