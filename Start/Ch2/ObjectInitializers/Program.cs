// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using object and collection initializers

// TODO: Use the initializer syntax to create new objects
Dog dog = new Dog { Name = "Fido", Age = 4, IsTrained = true };
Cat cat = new Cat { Name = "Cat", Age = 3, IsDeclawed = false };

Console.WriteLine($"Dog: {dog.Name}, {dog.Age}");
Console.WriteLine($"Cat: {cat.Name}, {cat.Age}");

// TODO: Initializers can be used on anonymous types
var pet = new { Name = "Charlie", Age = 5 };
Console.WriteLine($"Pet: {pet.Name}, {pet.Age}");


// TODO: Collections can also be initialized this way
int[] numbers = new int[] { 1, 2, 3 };

Console.WriteLine($"{numbers.Length}");
// TODO: Initialize a collection with a set of objects

PetOwner petOwner = new PetOwner
{
    Name = "Joe",
    Pets = new List<Pet>
    {
        new Dog { Name = "Junebug", Age = 1 },
        new Cat { Name = "Whiskers", Age = 3},
    }
};

Console.WriteLine($"{petOwner.Name}");

foreach (Pet p in petOwner.Pets)
{
    Console.WriteLine($"Pet Name: {p.Name}");
}
