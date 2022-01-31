namespace Model
{
    public class Position
    {
        public enum CardinalDirection { NORTH, EAST, SOUTH, WEST }
        public CardinalDirection Direction { get; set; } = CardinalDirection.NORTH;
        public int X { get; set; } = 1;
        public int Y { get; set; } = 1;
    }
}