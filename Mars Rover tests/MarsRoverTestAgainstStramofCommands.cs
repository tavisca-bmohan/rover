using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mars_Rover;
using Xunit;

namespace Mars_Rover_tests
{
    [TestClass]
    public class MarsRoverTestAgainstStramofCommands// check stream
    {
        private MarsRoverDriver Rover = new MarsRoverDriver();
        private MapVectorOnSurface Actual = new MapVectorOnSurface();

        [TestMethod]
        public void TestRoverPositionForMoreThanOneLeftRotation()
        {
            Actual.X_Coordinate = 2; Actual.Y_Coordinate = 2; Actual.Current_Direction = Direction.East;
            Actual = Rover.FindRoverFinlPositionAndDirection(Actual, "LL");
            Xunit.Assert.Equal("2,2,West", $"{Actual.X_Coordinate},{Actual.Y_Coordinate},{Actual.Current_Direction}");

            Actual.X_Coordinate = 2; Actual.Y_Coordinate = 2; Actual.Current_Direction = Direction.East;
            Actual = Rover.FindRoverFinlPositionAndDirection(Actual, "LLLL");
            Xunit.Assert.Equal("2,2,East",$"{Actual.X_Coordinate},{Actual.Y_Coordinate},{Actual.Current_Direction}");
        }

        [TestMethod]
        public void TestRoverPositionForMoreThanOneRightRotation()
        {
            Actual.X_Coordinate = 2; Actual.Y_Coordinate = 2; Actual.Current_Direction = Direction.East;
            Actual = Rover.FindRoverFinlPositionAndDirection(Actual, "RR");
            Xunit.Assert.Equal("2,2,West", $"{Actual.X_Coordinate},{Actual.Y_Coordinate},{Actual.Current_Direction}");

            Actual.X_Coordinate = 2; Actual.Y_Coordinate = 2; Actual.Current_Direction = Direction.East;
            Actual = Rover.FindRoverFinlPositionAndDirection(Actual, "RRRR");
            Xunit.Assert.Equal("2,2,East", $"{Actual.X_Coordinate},{Actual.Y_Coordinate},{Actual.Current_Direction}");
        }

        [TestMethod]
        public void TestRoverPositionAfterMovingForward()
        {
            Actual.X_Coordinate = 2; Actual.Y_Coordinate = 2; Actual.Current_Direction = Direction.East;
            Actual = Rover.FindRoverFinlPositionAndDirection(Actual, "FFF");
            Xunit.Assert.Equal("5,2,East", $"{Actual.X_Coordinate},{Actual.Y_Coordinate},{Actual.Current_Direction}");
        }

        [TestMethod]
        public void TestForRandomSInputCommand()
        {
            Actual.X_Coordinate = 2; Actual.Y_Coordinate = 2; Actual.Current_Direction = Direction.North;
            Actual = Rover.FindRoverFinlPositionAndDirection(Actual, "LLLLRRFLF");
            Xunit.Assert.Equal("3,1,East", $"{Actual.X_Coordinate},{Actual.Y_Coordinate},{Actual.Current_Direction}");
        }
    }
}
