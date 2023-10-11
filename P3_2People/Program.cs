// See https://aka.ms/new-console-template for more information

Person[] people = new Person [3];

Console.WriteLine("Give me names");
for (var i = 0; i < people.Length; i++)
{
    people[i] = new Person();
}

people[0].name=(Console.ReadLine());
people[1].name=(Console.ReadLine());
people[2].name=(Console.ReadLine());

for (var i = 0; i < people.Length; i++)
{
           people[i].Greeting(); 
}