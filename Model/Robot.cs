namespace Model
{
    public class Robot
    {
        public Robot()
        {
            CurrentPosition = new Position();
            CurrentPosition.X = 1;
            CurrentPosition.Y = 1;
            CurrentPosition.Direction = Position.CardinalDirection.NORTH;
        }

        public Position CurrentPosition { get; set; }
    }
}
