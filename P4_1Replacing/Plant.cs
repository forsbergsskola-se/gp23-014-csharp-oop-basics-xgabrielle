
public class Plant
{
    public bool isGrown;

    public void PrintStatus()
    {
        if (isGrown)
            Console.WriteLine("Plant is a tree");
        else
            Console.WriteLine("Plant is a seed.");
        
    }


    public void Grow()
    {
        
        if (isGrown)
            Console.WriteLine("Plant has already grown");
        else
            Console.WriteLine("Plant is growing");
        isGrown = !isGrown;
    }

}