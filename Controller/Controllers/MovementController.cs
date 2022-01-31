using Controller.Interfaces;
using Model;

namespace Controller.Controllers
{
    public class MovementController : IMovementController
    {
        public Position MoveBackward(Position position)
        {
            switch (position.Direction)
            {
                case Position.CardinalDirection.NORTH:
                    position.Y--;
                    break;
                case Position.CardinalDirection.EAST:
                    position.X--;
                    break;
                case Position.CardinalDirection.SOUTH:
                    position.Y++;
                    break;
                case Position.CardinalDirection.WEST:
                    position.X++;
                    break;
                default:
                    break;
            }
            return position;
        }
        public Position MoveForward(Position position)
        {
            switch (position.Direction)
            {
                case Position.CardinalDirection.NORTH:
                    position.Y++;
                    break;
                case Position.CardinalDirection.EAST:
                    position.X++;
                    break;
                case Position.CardinalDirection.SOUTH:
                    position.Y--;
                    break;
                case Position.CardinalDirection.WEST:
                    position.X--;
                    break;
                default:
                    break;
            }
            return position;
        }
        public Position RotateLeft(Position position)
        {
            switch (position.Direction)
            {
                case Position.CardinalDirection.NORTH:
                    position.Direction = Position.CardinalDirection.WEST;
                    break;
                case Position.CardinalDirection.EAST:
                    position.Direction = Position.CardinalDirection.NORTH;
                    break;
                case Position.CardinalDirection.SOUTH:
                    position.Direction = Position.CardinalDirection.EAST;
                    break;
                case Position.CardinalDirection.WEST:
                    position.Direction = Position.CardinalDirection.SOUTH;
                    break;
                default:
                    break;
            }
            return position;
        }
        public Position RotateRight(Position position)
        {
            switch (position.Direction)
            {
                case Position.CardinalDirection.NORTH:
                    position.Direction = Position.CardinalDirection.EAST;
                    break;
                case Position.CardinalDirection.EAST:
                    position.Direction = Position.CardinalDirection.SOUTH;
                    break;
                case Position.CardinalDirection.SOUTH:
                    position.Direction = Position.CardinalDirection.WEST;
                    break;
                case Position.CardinalDirection.WEST:
                    position.Direction = Position.CardinalDirection.NORTH;
                    break;
                default:
                    break;
            }
            return position;
        }        

        public void MoveRobotThroughGrid(List<char> input, Grid grid, Robot robot)
        {
            foreach (char c in input)
            {
                switch (c)
                {
                    case 'F':
                        if(CanMoveForward(grid, robot))
                            robot.CurrentPosition = MoveForward(robot.CurrentPosition);
                        break;
                    case 'R':
                        robot.CurrentPosition = RotateRight(robot.CurrentPosition);
                        break;
                    case 'L':
                        robot.CurrentPosition = RotateLeft(robot.CurrentPosition);
                        break;
                    case 'S':
                        if (CanMoveBackward(grid, robot))
                            robot.CurrentPosition = MoveBackward(robot.CurrentPosition);
                        break;
                    default:
                        break;
                }
                
                Console.WriteLine("Input: {3} - Current Position: X: {0}, Y: {1}, Direction: {2}",
                    robot.CurrentPosition.X,
                    robot.CurrentPosition.Y,
                    robot.CurrentPosition.Direction,
                    c.ToString());
            }
        }

        private bool CanMoveForward(Grid grid, Robot robot)
        {
            if(robot.CurrentPosition.Direction == Position.CardinalDirection.NORTH)
            {
                if (robot.CurrentPosition.Y == grid.Height)
                {
                    return false;
                }
            } 
            else if (robot.CurrentPosition.Direction == Position.CardinalDirection.EAST)
            {
                if (robot.CurrentPosition.X == grid.Width)
                {
                    return false;
                }
            }
            else if (robot.CurrentPosition.Direction == Position.CardinalDirection.SOUTH)
            {
                if (robot.CurrentPosition.Y == 1)
                {
                    return false;
                }
            }
            else if (robot.CurrentPosition.Direction == Position.CardinalDirection.WEST)
            {
                if (robot.CurrentPosition.X == 1)
                {
                    return false;
                }
            }
            return true;
        }
        private bool CanMoveBackward(Grid grid, Robot robot)
        {
            if (robot.CurrentPosition.Direction == Position.CardinalDirection.NORTH)
            {
                if (robot.CurrentPosition.Y == 1)
                {
                    return false;
                }
            }
            else if (robot.CurrentPosition.Direction == Position.CardinalDirection.EAST)
            {
                if (robot.CurrentPosition.X == 1)
                {
                    return false;
                }
            }
            else if (robot.CurrentPosition.Direction == Position.CardinalDirection.SOUTH)
            {
                if (robot.CurrentPosition.Y == grid.Height)
                {
                    return false;
                }
            }
            else if (robot.CurrentPosition.Direction == Position.CardinalDirection.WEST)
            {
                if (robot.CurrentPosition.X == grid.Width)
                {
                    return false;
                }
            }
            return true;
        }
    }
}