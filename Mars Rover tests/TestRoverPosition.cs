using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Mars_Rover;

namespace Mars_Rover_tests
{
    [TestClass]
    public class TestRoverPosition
    {
        MapVectorOnSurface Map = new MapVectorOnSurface();
        [TestMethod]
        public void TestForRoverDefaultPosition()
        {
            RoverPosition Position = new RoverPosition();
            Xunit.Assert.Equal("0,0,North", $"{Position.Map.X_Coordinate }" +
                $",{Position.Map.Y_Coordinate },{Position.Map.Current_Direction }");
        }

        [TestMethod]
        public void TestForWrongDirection()
        {
            RoverPosition Position = new RoverPosition(5,3,'A');
            Xunit.Assert.Equal("5,3,Wrong_Direction", $"{Position.Map.X_Coordinate }" +
                $",{Position.Map.Y_Coordinate },{Position.Map.Current_Direction }");
        }

        [TestMethod]
        public void TestForRoverPositionEast()
        {
            var Position = new RoverPosition(1, 2, 'E');
            Xunit.Assert.Equal("1,2,East",$"{Position.Map.X_Coordinate }" +
                $",{Position.Map.Y_Coordinate },{Position.Map.Current_Direction }");

        }

        [TestMethod]
        public void TestForRoverPositionWest()
        {
            RoverPosition Position = new RoverPosition(3, 4, 'W');
            Xunit.Assert.Equal("3,4,West", $"{Position.Map.X_Coordinate }" +
                $",{Position.Map.Y_Coordinate },{Position.Map.Current_Direction }");
        }

        [TestMethod]
        public void TestForRoverPositionNorth()
        {
            RoverPosition Position = new RoverPosition(5, 3, 'N');
            Xunit.Assert.Equal("5,3,North", $"{Position.Map.X_Coordinate }" +
                $",{Position.Map.Y_Coordinate },{Position.Map.Current_Direction }");
        }

        [TestMethod]
        public void TestForRoverPositionSouth()
        {
            RoverPosition Position = new RoverPosition(4, 2, 'S');
            Xunit.Assert.Equal("4,2,South", $"{Position.Map.X_Coordinate }" +
                $",{Position.Map.Y_Coordinate },{Position.Map.Current_Direction }");
        }

    }
}
