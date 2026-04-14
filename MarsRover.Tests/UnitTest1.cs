namespace MarsRover.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void TurnLeft_FromNorth_FacesWest()
        {
            var rover = new Rover(0, 0, Direction.N);
            var plateau = new Plateau(5, 5);

            rover.ExecuteCommands(new List<Command> { Command.L }, plateau);

            Assert.That(rover.Direction, Is.EqualTo(Direction.W));
        }
        [Test]
        public void TurnRight_FromNorth_FacesEast()
        {
            var rover = new Rover(0, 0, Direction.N);
            var plateau = new Plateau(5, 5);

            rover.ExecuteCommands(new List<Command> { Command.R }, plateau);

            Assert.That(rover.Direction, Is.EqualTo(Direction.E));
        }
        [Test]
        public void Move_ForwardFacingNorth_IncreasesY()
        {
            var rover = new Rover(1, 1, Direction.N);
            var plateau = new Plateau(5, 5);

            rover.ExecuteCommands(new List<Command> { Command.M }, plateau);

            Assert.That(rover.X, Is.EqualTo(1));
            Assert.That(rover.Y, Is.EqualTo(2));
        }

        [Test]
        public void Move_ForwardFacingEast_IncreasesX()
        {
            var rover = new Rover(1, 1, Direction.E);
            var plateau = new Plateau(5, 5);

            rover.ExecuteCommands(new List<Command> { Command.M }, plateau);

            Assert.That(rover.X, Is.EqualTo(2));
            Assert.That(rover.Y, Is.EqualTo(1));
        }
        [Test]
        public void Move_OutOfBounds_DoesNotMove()
        {
            var rover = new Rover(5, 5, Direction.N);
            var plateau = new Plateau(5, 5);

            rover.ExecuteCommands(new List<Command> { Command.M }, plateau);

            Assert.That(rover.X, Is.EqualTo(5));
            Assert.That(rover.Y, Is.EqualTo(5));
        }
    }

    public class HelloWorldTests
    {
        [Test]
        public void Successfully_runs_a_test()
        {
            Assert.That(true, Is.True);
        }


    }

    }