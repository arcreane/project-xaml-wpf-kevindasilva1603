using System.Collections.Generic;
using System.Drawing;

public class Snake : IMovable
{
    public Direction Direction { get; private set; }
    private List<Segment> segments = new List<Segment>();

    public void Move()
    {
        // Logique de mouvement du serpent.
    }

    public void Grow()
    {
        // Logique pour ajouter un segment au serpent.
    }

    public void ChangeDirection(Direction newDirection)
    {
        Direction = newDirection;
    }
}
