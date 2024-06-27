using cwiczenia_4.Models;

namespace cwiczenia_4.Database;

public class AnimalDatabase
{
    public List<Animal> Animals { get; set; } = new List<Animal>();

    public AnimalDatabase()
    {
        Animals.Add(new Animal());
        Animals.Add(new Animal());
        Animals.Add(new Animal());
        Animals.Add(new Animal());
    }
}