namespace Model
{
    public class Position
    {
        public enum CardinalDirection { NORTH, EAST, SOUTH, WEST }
        public CardinalDirection Direction { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}