using Controller;
using ConsoleApp.Helpers;
using Model;

namespace ConsroleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Set Mars plateau size (Width X Heigth):");
            var size = Console.ReadLine();

            int width = InputHelper.GetWidthFromInput(size);
            int heigth = InputHelper.GetHeigthFromInput(size);
            IGridController controller = new GridController();
            controller.CreateGrid(width, heigth);

            Console.WriteLine("Set robot input (F, R, L):");
            var userInput = Console.ReadLine();
            List<Char> input = InputHelper.GetCharsFromInput(userInput);

            MovementController.MoveRobotThroughGrid(input, controller.GetGrid(), new Robot());
        }
    }
}