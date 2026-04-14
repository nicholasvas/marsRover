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
        public void TurnRight_FromSouth_FacesEast()
        {
            var rover = new Rover(0, 0, Direction.S);
            var plateau = new Plateau(5, 5);

            rover.ExecuteCommands(new List<Command> { Command.R }, plateau);

            Assert.That(rover.Direction, Is.EqualTo(Direction.W));
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