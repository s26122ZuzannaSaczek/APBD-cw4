using cwiczenia_4.Models;

namespace cwiczenia_4.Database;

public static class AnimalDatabase
{
    public static List<Animal> Animals { get; set; } = new List<Animal>
    {
        new Animal
        {
            Id = 1, Name = "Foxy", Type = "dog", Weight = 10.0, Colour = "orange"
        },
        new Animal
        {
            Id = 2, Name = "Void", Type = "cat", Weight = 5.0, Colour = "black"
        }
        
    };
    
}