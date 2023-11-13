
using System.Threading.Channels;

public class Player
{
    public int health;

    public void Attack(Monster target)
    {
        target.health--;
        Console.WriteLine($"You attacked the monster. It has {target.health} Health.");
    }

    public void Heal()
    {
        this.health = 3;
        Console.WriteLine("You healed");
    }
     
    
}