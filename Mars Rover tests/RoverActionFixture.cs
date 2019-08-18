using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mars_Rover;

namespace Mars_Rover_tests
{
    
    [TestClass]
    public class RoverActionFixture
    {
        MapVectorOnSurface Map = new MapVectorOnSurface();
        private RoverActionsOnCommand Action = new RoverActionsOnCommand();

        //-------------Test for rover action left----------------------
        [TestMethod]
        public void TestForRotatingRoverLeftFromInitialPosition()
        {
            var initialPosition = new RoverPosition();
            Xunit.Assert.Equal("West", $"{Action.TurnLeft(initialPosition.Map).Current_Direction}");
        }

        [TestMethod]
        public void TestForRotatingRoverLeftFromAllDirection()
        {
            Map.Current_Direction = Direction.East;
            Xunit.Assert.Equal("North", $"{Action.TurnLeft(Map).Current_Direction}");

            Map.Current_Direction = Direction.North;
            Xunit.Assert.Equal("West", $"{Action.TurnLeft(Map).Current_Direction}");

            Map.Current_Direction = Direction.West;
            Xunit.Assert.Equal("South", $"{Action.TurnLeft(Map).Current_Direction}");

            Map.Current_Direction = Direction.South;
            Xunit.Assert.Equal("East", $"{Action.TurnLeft(Map).Current_Direction}");
        }

        //------------Test for rover action right-----------------------

        [TestMethod]
        public void TestForRotatingRoverRightFromInitialPosition()
        {
            Map.Current_Direction = Direction.North;
            Xunit.Assert.Equal("East", $"{Action.TurnRight(Map).Current_Direction}");
        }

        [TestMethod]
        public void TestForRotatingRoverRightFromAllDirection()
        {
            Map.Current_Direction = Direction.East;
            Xunit.Assert.Equal("South", $"{Action.TurnRight(Map).Current_Direction}");

            Map.Current_Direction = Direction.South;
            Xunit.Assert.Equal("West", $"{Action.TurnRight(Map).Current_Direction}");

            Map.Current_Direction = Direction.West;
            Xunit.Assert.Equal("North", $"{Action.TurnRight(Map).Current_Direction}");

            Map.Current_Direction = Direction.North;
            Xunit.Assert.Equal("East", $"{Action.TurnRight(Map).Current_Direction}");
        }

        //---------------Test for rover action forward---------------------

        [TestMethod]
        public void TestForMovingRoverinForwardEastDirection()
        {
            Map.X_Coordinate = 2; Map.Y_Coordinate = 2; Map.Current_Direction = Direction.East;
            Map = Action.MoveForward(Map);
            Xunit.Assert.Equal("3,2,East", $"{Map.X_Coordinate}," +
                $"{Map.Y_Coordinate},{Map.Current_Direction}");
        }

        [TestMethod]
        public void TestForMovingRoverinForwardWestDirection()
        {
            Map.X_Coordinate = 2; Map.Y_Coordinate = 2; Map.Current_Direction = Direction.West;
            Map = Action.MoveForward(Map);
            Xunit.Assert.Equal("1,2,West", $"{Map.X_Coordinate}," +
                $"{Map.Y_Coordinate},{Map.Current_Direction}");
        }

        [TestMethod]
        public void TestForMovingRoverinForwardNorthDirection()
        {
            Map.X_Coordinate = 2; Map.Y_Coordinate = 2; Map.Current_Direction = Direction.North;
            Map = Action.MoveForward(Map);
            Xunit.Assert.Equal("2,3,North", $"{Map.X_Coordinate}," +
                $"{Map.Y_Coordinate},{Map.Current_Direction}");
        }

        [TestMethod]
        public void TestForMovingRoverinForwardSouthDirection()
        {
            Map.X_Coordinate = 2; Map.Y_Coordinate = 2; Map.Current_Direction = Direction.South;
            Map = Action.MoveForward(Map);
            Xunit.Assert.Equal("2,1,South", $"{Map.X_Coordinate}," +
                $"{Map.Y_Coordinate},{Map.Current_Direction}");
        }

        [TestMethod]
        public void TestForMoveForwardCommandinWrongDirection()
        {
            Map.X_Coordinate = 2; Map.Y_Coordinate = 2; Map.Current_Direction = Direction.Wrong_Direction;
            Map = Action.MoveForward(Map);
            Xunit.Assert.Equal("2,2,Wrong_Direction", $"{Map.X_Coordinate}," +
                $"{Map.Y_Coordinate},{Map.Current_Direction}");
        }
    }
}
