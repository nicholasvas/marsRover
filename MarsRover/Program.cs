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


            while(true)
            {
                Console.WriteLine("Enter Rover position: ");
                var positionInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(positionInput))
                    break;

                var parts = positionInput.Split(' ');
                int x = int.Parse(parts[0]);
                int y = int.Parse(parts[1]);
                Direction direction = Enum.Parse<Direction>(parts[2]);

                var rover = new Rover(x, y, direction);

                string instructions = Console.ReadLine();

               
                var commands = instructions
                    .Select(c => Enum.Parse<Command>(c.ToString()))
                    .ToList();

                
                rover.ExecuteCommands(commands, plateau);

               
                Console.WriteLine($"{rover.X} {rover.Y} {rover.Direction}");
            }
        }
    }
}
