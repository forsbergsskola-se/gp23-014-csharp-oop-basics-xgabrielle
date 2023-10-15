//Player A has 200 Gold,
//110 Stone,
//53 Wood.
//He is level 12 and has
//123 Experience.
//He has an active VIP subscription, but
//PVP disabled.
//His display name is Marc and his
//e-mail address marc@zaku.de

Console.WriteLine();

Player player = new Player();

Console.WriteLine(player.name);
Console.WriteLine(player.email);
Console.WriteLine(player.experience);
Console.WriteLine(player.gold);
Console.WriteLine(player.pvp);
Console.WriteLine(player.vip);
Console.WriteLine(player.level);
Console.WriteLine(player.stone);
Console.WriteLine(player.wood);