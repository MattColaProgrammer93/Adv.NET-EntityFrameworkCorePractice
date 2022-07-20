using EntityFrameworkCorePractice;

using AnimalContext dbContext = new();

// Add with EF Core
Animal a = new()
{
    Name = "Charizard",
    Type = "Fire",
    Ability = "Shoot fireballs and spit flames"
};

Animal a2 = new()
{
    Name = "Piku",
    Type = "Lighting",
    Ability = "Controls lighting through it's tail"
};

dbContext.Animals.Add(a); // Prepares the Animal insert statement
dbContext.SaveChanges(); // Executes pending insert/update/delete

dbContext.Animals.Add(a2); // Prepares the Animal insert statement
dbContext.SaveChanges(); // Executes pending insert/update/delete

// Retrieve Animals from DB
List<Animal> list = dbContext.Animals.ToList(); // Method syntax

foreach (Animal animal in list)
{
    Console.WriteLine($"{animal.Name} has a type of {animal.Type}");
    Console.WriteLine();
}
