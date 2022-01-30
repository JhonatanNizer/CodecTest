namespace Model
{
    public class Robot
    {
        public int CurrentX { get; set; } = 1;
        public int CurrentY { get; set; } = 1;
        public Position.CardinalDirection CurrentDirection { get; set; } = Position.CardinalDirection.NORTH;
    }
}
