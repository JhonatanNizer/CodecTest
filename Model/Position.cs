namespace Model
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public enum CardinalDirection { NORTH, EAST, SOUTH, WEST }
        public CardinalDirection direction { get; set; }
    }
}