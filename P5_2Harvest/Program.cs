// See https://aka.ms/new-console-template for more information

using P5_2Harvest;

Console.WriteLine("Hello, World!");

Wheat wheat = new Wheat();

wheat.CanBeProcessedToBread();
wheat.CanBeHarvest();
wheat.CanGrow();

Grain grain = new Grain();

grain.CanBeHarvest();
grain.CanGrow();

Plant plant = new Plant();
plant.CanGrow();