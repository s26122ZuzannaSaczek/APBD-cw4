using cwiczenia_4.Database;
using cwiczenia_4.Models;
using Microsoft.AspNetCore.Mvc;

namespace cwiczenia_4.Controllers;

[Route("api/visits")]
[ApiController]
public class VisitsController : ControllerBase
{
    //private static List<Visit> _visits = new VisitsDatabase().Visits;
    
    [HttpGet]
    public IActionResult GetVisits()
    {
        return Ok(VisitsDatabase.Visits);
    }
    
    [HttpGet("{animalId:int}")]
    public IActionResult GetVisit(int animalId)
    {
        var animal = AnimalDatabase.Animals.FirstOrDefault(a => a.Id == animalId);
        
        if (animal == null)
        {
            return NotFound($"Animal with id {animalId} was not found");
        }
        
        var visit = VisitsDatabase.Visits.FirstOrDefault(a => a.AnimalId == animal.Id);

        return Ok(visit);
    }

    [HttpPost]
    public IActionResult CreateVisit(Visit visit)
    {
        VisitsDatabase.Visits.Add(visit);
        return StatusCode(StatusCodes.Status201Created);
    }
    
    
}