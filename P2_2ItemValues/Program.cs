

Item [] things = new  Item [3];

for (var i = 0; i < things.Length; i++)
{
    things[i] = new Item();
}

things[0].goldValue = 100;
things[1].goldValue = 200;
things[2].goldValue = 300;

for (var i = 0; i < things.Length; i++)
{
    Console.WriteLine(things[i].goldValue);
    
}

Console.WriteLine("Hello, World!");