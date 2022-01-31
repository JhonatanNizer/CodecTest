using Controller.Helpers;
using Controller.Interfaces;
using Model;

namespace Controller.Controllers
{
    public class GameController : IGameController
    {
        public void Run()
        {
            Console.WriteLine("Set Mars plateau size (WidthXHeigth):");
            var size = Console.ReadLine();

            int width = InputHelper.GetWidthFromInput(size);
            int heigth = InputHelper.GetHeigthFromInput(size);

            IGridController gridController = new GridController();
            gridController.CreateGrid(width, heigth);
            Grid grid = gridController.GetGrid();

            Robot robot = new Robot();

            MovementController movementController = new MovementController();

            while (true)
            {
                Console.WriteLine("Set robot input (F, R, L, S):");
                var userInput = Console.ReadLine();
                List<Char> input = InputHelper.GetValidCharsFromInput(userInput);
                movementController.MoveRobotThroughGrid(input, grid, robot);
            }
        }
    }
}
