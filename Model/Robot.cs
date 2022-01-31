namespace Model
{
    public class Robot
    {
        public Robot()
        {
            position.X = 1;
            position.Y = 1;
            position.Direction = Position.CardinalDirection.NORTH;
        }

        public Position position { get; set; }
    }
}
