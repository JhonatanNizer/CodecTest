using Model;

namespace Controller
{
    public interface IMovementController
    {
        public Position MoveBackward(Position position);
        public Position MoveForward(Position position);
        public Position RotateLeft(Position position);
        public Position RotateRight(Position position);
    }
}
