// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

Console.WriteLine("Hello, World!");

Player playerOne = new Player();
Player playerTwo = new Player();
Player playerThree = playerOne;

Console.WriteLine("Player 1 attacks Player 2");
playerOne.Attack(playerTwo);
Console.WriteLine($"Player 1, Damage: {playerOne.damage}");
Console.WriteLine($"Player 2, Damage: {playerTwo.damage}");

Console.WriteLine("Player 2 attacks Player 1");
playerTwo.Attack(playerOne);
Console.WriteLine($"Player 1, Damage: {playerOne.damage}");
Console.WriteLine($"Player 2, Damage: {playerTwo.damage}");

Console.WriteLine("Player 1 attacks Player 2");
playerOne.Attack(playerTwo);
Console.WriteLine($"Player 1, Damage: {playerOne.damage}");
Console.WriteLine($"Player 2, Damage: {playerTwo.damage}");

Console.WriteLine("Player 2 attacks Player 3");
playerTwo.Attack(playerThree);
Console.WriteLine($"Player 1, Damage: {playerOne.damage}");
Console.WriteLine($"Player 2, Damage: {playerTwo.damage}");
Console.WriteLine($"Player 3, Damage: {playerThree.damage}");