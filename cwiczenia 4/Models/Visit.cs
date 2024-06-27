namespace cwiczenia_4.Models;

public class Visit
{
    public int Id { get; set; }
    public int AnimalId { get; set; }
    public DateTime VisitDate { get; set; }
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }
}