namespace MarsRover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Enter plateau size: ");
            var plateauInput = Console.ReadLine().Split(" ");
            int limitX = int.Parse(plateauInput[0]);
            int limitY = int.Parse(plateauInput[1]);

            var plateau = new Plateau(limitX, limitY);
        }
    }
}
