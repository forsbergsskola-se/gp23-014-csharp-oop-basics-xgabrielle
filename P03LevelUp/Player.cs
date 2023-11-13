public class Player
{
    public int level;
    public int experience;
    
    public void GrantExperience()
    {
        experience += int.Parse(Console.ReadLine());
        
        if (experience > 99)
        {
            level += experience / 100;
            experience %= 100;
        }
    }
}

