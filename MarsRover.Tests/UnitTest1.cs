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