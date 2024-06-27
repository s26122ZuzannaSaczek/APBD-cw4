using cwiczenia_4.Models;

namespace cwiczenia_4.Database;

public static class VisitsDatabase
{

    public static List<Visit> Visits = new List<Visit>
    {
        new Visit{
        
            Id = 1, AnimalId = 2, VisitDate = new DateTime(2024, 05, 12), Description = "Annual Check up", Price = 100
        },
        new Visit
        {
            Id = 2, AnimalId = 1, VisitDate = new DateTime(2024, 03, 20), Description = "Vaccine", Price = 250
        }
    };
}