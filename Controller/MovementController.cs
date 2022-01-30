using Model;

namespace Controller
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
    }
}