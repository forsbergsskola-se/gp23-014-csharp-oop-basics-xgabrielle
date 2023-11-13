
public class Knight
{
    public Shield shield;
    public Sword sword;
    

    public void GetHit(Sword sword)
    {
        if (shield !=null && sword==null)
        {
            Console.WriteLine("Knights Shield fends off the strike.");
        }
        else if (shield != null && sword != null)
        {
            Console.WriteLine("Knights Shield was pierced by the Sword.");
            shield = null;
        }
        else
        {
            Console.WriteLine("The Knight has no Shield and is wounded.");
        }
    }


    public void Attack(Knight knight)
    {
        if (sword !=null)
        {
            Console.WriteLine("Knight attacks Knight with a Sword.");
            knight.GetHit(sword);
        }
        else
        {
            Console.WriteLine("Knight attacks Knight with Bare Hands.");
            knight.GetHit(null);
        }
    }
}