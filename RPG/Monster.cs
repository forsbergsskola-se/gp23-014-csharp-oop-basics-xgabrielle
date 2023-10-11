
public class Monster
{
    public int health;

    public void Attack(Player target)
    {
        target.health--;
        Console.WriteLine($"The monster attacked you, you have {target.health} health.");
    }

}