using System.Drawing;

public abstract class Food
{
    protected Point position;

    public Point Position => position;

    public abstract Point GeneratePosition();
}
