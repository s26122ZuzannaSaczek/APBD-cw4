using Microsoft.AspNetCore.Mvc;
using cwiczenia_4.Database;
using cwiczenia_4.Models;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace cwiczenia_4.Controllers;

[Route("api/animals")]
[ApiController]
public class AnimalController : ControllerBase
{
    //private static List<Animal> _animals = new AnimalDatabase().Animals;
    //private static List<Visit> _visits = new VisitsDatabase().Visits;
    
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok(AnimalDatabase.Animals);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = AnimalDatabase.Animals.FirstOrDefault(a => a.Id == id);
        if (animal == null)
        {
            return NotFound($"Animal with id {id} was not found");
        }

        return Ok(animal);
    }

    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        AnimalDatabase.Animals.Add(animal);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        var animalToEdit = AnimalDatabase.Animals.FirstOrDefault(a => a.Id == id);

        if (animalToEdit == null)
        {
            return NotFound($"Animal with id {id} was not found");
        }

        AnimalDatabase.Animals.Remove(animalToEdit);
        AnimalDatabase.Animals.Add(animal);
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animalToRemove = AnimalDatabase.Animals.FirstOrDefault(a => a.Id == id);

        if (animalToRemove == null)
        {
            //return NotFound($"Animal with id {id} was not found");
            return NoContent();
        }

        AnimalDatabase.Animals.Remove(animalToRemove);
        return NoContent();
    }
}