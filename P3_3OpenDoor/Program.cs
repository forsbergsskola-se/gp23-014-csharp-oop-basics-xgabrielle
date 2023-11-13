// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

House redHouse = new House();
House blueHouse = new House();
Console.WriteLine($"Red House {redHouse.isDoorOpen}");
Console.WriteLine($"Blue House {blueHouse.isDoorOpen}");
redHouse.OpenDoor();
Console.WriteLine($"Red House {redHouse.isDoorOpen}");
Console.WriteLine($"Blue House {blueHouse.isDoorOpen}");
blueHouse.OpenDoor();
Console.WriteLine($"Blue House {blueHouse.isDoorOpen}");
Console.WriteLine($"Red House {redHouse.isDoorOpen}");