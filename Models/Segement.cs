using System.Drawing;

public class Segment
{
    public Point Position { get; private set; }

    public Segment(Point initialPosition)
    {
        Position = initialPosition;
    }
}
