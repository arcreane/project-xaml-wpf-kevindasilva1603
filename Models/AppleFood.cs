public enum Effect { IncreaseSpeed, DecreaseSpeed, ExtraLife, DoublePoints }

public class AppleFood : Food
{
    public Effect effect;

    public override Point GeneratePosition()
    {
        
        return new Point(); 
    }

   
}
