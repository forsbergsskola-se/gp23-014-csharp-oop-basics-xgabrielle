public class Player
{
    public void GrantExperience(int level, int experience)
    {
        Console.WriteLine($"{level} Level and {experience} Experience");
        while (true)
        {
            experience = int.Parse(Console.ReadLine());
            if (experience > 100)
            {
                level++;
                experience = experience - 100;
                Console.WriteLine($"{level} Level and {experience} Experience");
            }
            else
            {
                Console.WriteLine($"{level} Level and {experience} Experience");
            }
            
        }
    }
}