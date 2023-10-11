// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

ScoreCounter one = new ScoreCounter();
ScoreCounter two = one;
ScoreCounter three = two;
ScoreCounter four = three;

one.IncreaseScore();
two.IncreaseScore();
three.IncreaseScore();
four.IncreaseScore();

Console.WriteLine(one.score);
Console.WriteLine(two.score);
Console.WriteLine(three.score);
Console.WriteLine(four.score);
